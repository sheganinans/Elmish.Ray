namespace Elmish.Ray

open Elmish
open Elmish.Ray.Core

type RayProgram<'arg, 'model, 'msg> = internal {
    ElmishProgram : Program<'arg, 'model, 'msg, unit>
    FpsTarget : int<FPS>
    Width : int<Width>
    Height : int<Height>
    Title : string
  }

[<RequireQualifiedAccess>]
module RayProgram =
  let mkSimple init update view = {
      ElmishProgram = Program.mkSimple init update view
      FpsTarget = 60<FPS>
      Width = 800<Width>
      Height = 450<Height>
      Title = "default title"
    }
    
  let mkProgram init update view = {
      ElmishProgram = Program.mkProgram init update view
      FpsTarget = 60<FPS>
      Width = 800<Width>
      Height = 450<Height>
      Title = "default title"
    }
    
  let withFpsTarget fpsTarget program = { program with FpsTarget = fpsTarget }
  
  let withTermination pred exit program = { program with ElmishProgram = Program.withTermination pred exit program.ElmishProgram }

  let withWindowDimensions width height program = { program with Width = width; Height = height }
  
  let withTitle title program = { program with Title = title }
  
  let runWindow (arg : 'arg) (program : RayProgram<'arg, 'model, 'message>) =
    InitWindow program.Width program.Height program.Title
    SetTargetFPS program.FpsTarget
    Program.runWithDispatch id arg program.ElmishProgram
      
type KeyHandler<'model> =
  | KeyHandler of (KeyboardKey [] * ('model -> 'model)) []