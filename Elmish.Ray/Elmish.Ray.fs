namespace Elmish.Ray

open System.Reflection
open Elmish
open Elmish.Ray.Core

[<Struct>]
type internal RingState<'item> =
  | Writable of wx:'item array * ix:int
  | ReadWritable of rw:'item array * wix:int * rix:int

type internal RingBuffer<'item>(size) =
  let doubleSize ix (items: 'item array) =
    seq {
      yield! items |> Seq.skip ix
      yield! items |> Seq.take ix
      for _ in 0..items.Length do yield Unchecked.defaultof<'item>
    } |> Array.ofSeq

  let mutable state : 'item RingState = Writable (Array.zeroCreate (max size 10), 0)

  member _.Pop () =
    match state with
    | ReadWritable (items, wix, rix) ->
      let rix' = (rix + 1) % items.Length
      match rix' = wix with
      | true -> state <- Writable (items, wix)
      | _    -> state <- ReadWritable (items, wix, rix')
      Some items[rix]
    | _ -> None

  member _.Push (item: 'item) =
    match state with
    | Writable (items, ix) ->
      items[ix] <- item
      let wix = (ix + 1) % items.Length
      state <- ReadWritable(items, wix, ix)
    | ReadWritable (items, wix, rix) ->
      items[wix] <- item
      let wix' = (wix + 1) % items.Length
      match wix' = rix with
      | true -> state <- ReadWritable (items |> doubleSize rix, items.Length, 0)
      | _    -> state <- ReadWritable (items, wix', rix)

module internal ElmProgram =
  module Cmd =
    let internal exec onError (dispatch: Dispatch<'msg>) (cmd: Cmd<'msg>) =
      cmd |> List.iter (fun call -> try call dispatch with ex -> onError ex)

  module Subs = Sub.Internal

  let init
    (everyFrame : 'model -> 'model)
    (keyHandler : 'model -> Dispatch<'msg> -> unit)
    (arg: 'arg)
    (program: Program<'arg, 'model, 'msg, unit>) =
    
    let init = Program.init program
    let update = Program.update program
    let setState = Program.setState program
    let onError = Program.onError program
    let subscribe =
      typeof<Program<'arg, 'model, 'msg, unit>>
        .GetProperty("subscribe", BindingFlags.NonPublic ||| BindingFlags.Instance)
        .GetValue program :?> _
    let model, cmd = init arg
    let sub = subscribe model
    let toTerminate, terminate =
      typeof<Program<'arg, 'model, 'msg, unit>>
        .GetProperty("termination", BindingFlags.NonPublic ||| BindingFlags.Instance)
        .GetValue program :?> _
    let rb = RingBuffer 10
    let mutable reentered = false
    let mutable state = model
    let mutable activeSubs = Subs.empty
    let mutable terminated = false
    let rec dispatch msg =
      if not terminated then
        rb.Push msg
        if not reentered then
          reentered <- true
          processMsgs ()
          reentered <- false
    and processMsgs () =
      let mutable nextMsg = rb.Pop ()
      while not terminated && Option.isSome nextMsg do
        let msg = nextMsg.Value
        if toTerminate msg then
          Subs.Fx.stop onError activeSubs
          terminate state
          terminated <- true
        else
          let model', cmd' = update msg state
          let sub' = subscribe model'
          setState model' dispatch
          activeSubs <- Subs.diff activeSubs sub' |> Subs.Fx.change onError dispatch
          cmd' |> Cmd.exec (fun ex -> onError ($"Error handling the message: %A{msg}", ex)) dispatch
          state <- model'
          nextMsg <- rb.Pop ()

    reentered <- true
    setState model dispatch
    activeSubs <- Subs.diff activeSubs sub |> Subs.Fx.change onError dispatch
    cmd |> Cmd.exec (fun ex -> onError ("Error intitializing:", ex)) dispatch
    fun () ->
      state <- everyFrame state
      keyHandler state dispatch
      processMsgs ()
      reentered <- false
      BeginDrawing ()
      Program.view program state dispatch
      EndDrawing ()

type RayProgram<'arg, 'model, 'msg> = internal {
    ElmishProgram : Program<'arg, 'model, 'msg, unit>
    FpsTarget : int<FPS>
    Width : int<Width>
    Height : int<Height>
    Title : string
    WindowFlags : ConfigFlags list
    KeyHandler : 'model -> Dispatch<'msg> -> unit
    EveryFrame : 'model -> 'model
  }

[<RequireQualifiedAccess>]
module RayProgram =
  let mkSimple init update view keyHandler = {
      ElmishProgram = Program.mkSimple init update view
      FpsTarget = 60<FPS>
      Width = 800<Width>
      Height = 450<Height>
      Title = "default title"
      WindowFlags = []
      KeyHandler = keyHandler
      EveryFrame = id 
    }
    
  let mkProgram init update view keyHandler = {
      ElmishProgram = Program.mkProgram init update view
      FpsTarget = 60<FPS>
      Width = 800<Width>
      Height = 450<Height>
      Title = "default title"
      WindowFlags = []
      KeyHandler = keyHandler
      EveryFrame = id 
    }
    
  let withFpsTarget fpsTarget program = { program with FpsTarget = fpsTarget }
  
  let withTermination pred exit program = { program with ElmishProgram = Program.withTermination pred exit program.ElmishProgram }

  let withWindowDimensions width height program = { program with Width = width; Height = height }
  
  let withTitle title program = { program with Title = title }
  
  let withWindowFlags flags program = { program with WindowFlags = flags }
  
  let withEveryFrame ef program = { program with EveryFrame = ef }
  
  let runWindow (arg : 'arg) (program : RayProgram<'arg, 'model, 'msg>) =
    InitWindow program.Width program.Height program.Title
    SetTargetFPS program.FpsTarget
    program.WindowFlags |> List.iter SetConfigFlags
    let run = ElmProgram.init program.EveryFrame program.KeyHandler arg program.ElmishProgram
    while not (WindowShouldClose ()) do run ()
    CloseWindow ()