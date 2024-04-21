namespace Elmish.Ray

open Elmish
open Elmish.Ray.Core

type RayProgram<'arg, 'model, 'msg> = internal {
    ElmishProgram : Program<'arg, 'model, 'msg, unit>
    FpsTarget : int
    Width : int
    Height : int
    Title : string
  }

[<RequireQualifiedAccess>]
module RayProgram =
  let mkSimple init update view = {
      ElmishProgram = Program.mkSimple init update view
      FpsTarget = 60
      Width = 800
      Height = 450
      Title = "default title"
    }
    
  let mkProgram init update view = {
      ElmishProgram = Program.mkProgram init update view
      FpsTarget = 60
      Width = 800
      Height = 450
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