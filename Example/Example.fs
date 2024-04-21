module Example

open Elmish
open Elmish.Ray
open Elmish.Ray.Core
open Elmish.Ray.Shapes
open Elmish.Ray.Text
open Elmish.Ray.Textures

open Elmish.Ray.Conversions

type Model =
  {
    Buildings : (Rectangle * Color) []
    Player : Rectangle
    Camera : Camera2D
    Count : int
  }
  
let maxBuildings = 100
let screenWidth = 800<Width>
let screenHeight = 450<Height>
 
let genBuildings (n : int) =
  let mutable buildings = Array.zeroCreate<Rectangle> n
  let mutable colors = Array.zeroCreate<Color> n
  let mutable spacing = 0
  for i in 0 .. n - 1 do 
    buildings[i].Width <- float32 (GetRandomValue 50 200)
    buildings[i].Height <- float32 (GetRandomValue 100 800)
    buildings[i].Y <- float32 screenHeight - 130f - float32 buildings[i].Height
    buildings[i].X <- float32 (-6000 + spacing)
    spacing <- spacing + int buildings[i].Width
    colors[i] <- Color (GetRandomValue 200 240, GetRandomValue 200 240, GetRandomValue 200 250, 255)
  Array.zip buildings colors
  
type Msg = Continue | Quit

let view (model : Model) (dispach : Msg -> unit) =
  BeginDrawing ()
  ClearBackground Color.RayWhite
  BeginMode2D model.Camera
  DrawRectangle -6000<X> 320<Y> 13000<Width> 8000<Height> Color.LightGray

  for building, color in model.Buildings do
    DrawRectangleRec building color
        
  DrawRectangleRec model.Player Color.Red
  
  DrawRectangle (int model.Camera.Target.X * 1<X>) -500<Y> 1<Width> (screenHeight * 4) Color.Green
  
  DrawLine (-int screenWidth * 10<X>) (int model.Camera.Target.Y * 1<Y>) (int screenWidth * 10<X>) (int model.Camera.Target.Y * 1<Y>) Color.Green

  EndMode2D ()
  
  DrawText "SCREEN AREA" 640<X> 10<Y> 20<FontSize> Color.Red
  
  DrawRectangle 0<X> 0<Y> screenWidth 5<Height> Color.Red
  DrawRectangle 0<X> 5<Y> 5<Width> (screenHeight - 10<Height>) Color.Red
  DrawRectangle (screenWidth - 5<Width> |> convInt<Width, X>) 5<Y> 5<Width> (screenHeight - 10<Height>) Color.Red
  DrawRectangle 0<X> (screenHeight - 5<Height> |> convInt<Height, Y>) screenWidth 5<Height> Color.Red
  
  DrawRectangle 10<X> 10<Y> 250<Width> 113<Height> (ColorAlpha Color.SkyBlue 0.5f<Alpha>)
  DrawRectangle 10<X> 10<Y> 250<Width> 113<Height> Color.Blue
  
  DrawText $"Free 2d camera controls: {model.Count}"        20<X>  20<Y> 10<FontSize> Color.Black
  DrawText $"- Right/Left to move Offset: {model.Player.X}" 40<X>  40<Y> 10<FontSize> Color.DarkGray
  DrawText "- Mouse Wheel to Zoom in-out"                   40<X>  60<Y> 10<FontSize> Color.DarkGray
  DrawText "- A/S to Rotate"                                40<X>  80<Y> 10<FontSize> Color.DarkGray
  DrawText "- R to reset Zoom and Rotation"                 40<X> 100<Y> 10<FontSize> Color.DarkGray
        
  EndDrawing ()
  
  dispach Continue

let update (msg : Msg) (model : Model) =
  let mutable model = { model with Count = model.Count + 1 }
  let mutable player = model.Player
  let mutable camera = model.Camera
  if IsKeyDown KeyboardKey.Right then player.X <- player.X + 20f
  if IsKeyDown KeyboardKey.Left  then player.X <- player.X - 20f
  if IsKeyDown KeyboardKey.A then camera.Rotation <- camera.Rotation - 1f
  if IsKeyDown KeyboardKey.S then camera.Rotation <- camera.Rotation + 1f
  if camera.Rotation > 40f then camera.Rotation <- 40f
  if camera.Rotation < -40f then camera.Rotation <- -40f
  camera.Zoom <- camera.Zoom + (float32 (GetMouseWheelMove ()) * 0.05f)
  if camera.Zoom > 3f then camera.Zoom <- 3f
  if camera.Zoom < 0.1f then camera.Zoom <- 0.1f
  if IsKeyPressed KeyboardKey.R then
    camera.Zoom <- 1f
    camera.Rotation <- 0f
  camera.Target <- Vector2 (float32 player.X + 20f, float32 player.Y + 20f)
  model <- { model with Camera = camera; Player = player }
  model, Cmd.none
  
let init () =
  let buildings = genBuildings maxBuildings
  let player = Rectangle (400f, 280f, 40f, 40f)
  let mutable camera = Camera2D ()
  camera.Target <- Vector2 (float32 player.X + 20f, float32 player.Y + 20f)
  camera.Offset <- Vector2 (float32 screenWidth / 2f, float32 screenHeight / 2f)
  camera.Rotation <- 0f
  camera.Zoom <- 1f
  { Buildings = buildings; Player = player; Camera = camera; Count = 0 }, Cmd.none
  
  
RayProgram.mkProgram init update view
|> RayProgram.withTermination (fun _ -> WindowShouldClose ()) (fun _ -> CloseWindow ())
|> RayProgram.runWindow ()