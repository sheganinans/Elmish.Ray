namespace Elmish.Ray
#nowarn "9"

open System.Numerics

type Vector2 = System.Numerics.Vector2
type Vector3 = System.Numerics.Vector3
type Vector4 = System.Numerics.Vector4
type Matrix = Matrix4x4
type Quaternion = System.Numerics.Quaternion
type Color = Raylib_cs.Color
type Rectangle = Raylib_cs.Rectangle

type Image = Raylib_cs.Image
type Texture = Raylib_cs.Texture2D
type RenderTexture = RenderTexture2D
type NPatchInfo = Raylib_cs.NPatchInfo
type GlyphInfo = Raylib_cs.GlyphInfo
type Font = Raylib_cs.Font

type Camera3D = Raylib_cs.Camera3D

type Camera2D = Raylib_cs.Camera2D
type Mesh = Raylib_cs.Mesh
type Shader = Raylib_cs.Shader
type MaterialMap = Raylib_cs.MaterialMap
type Material = Raylib_cs.Material
type Transform = Raylib_cs.Transform
type BoneInfo = Raylib_cs.BoneInfo
type Model = Raylib_cs.Model
type ModelAnimation = Raylib_cs.ModelAnimation
type Ray = Raylib_cs.Ray
type RayCollision = Raylib_cs.RayCollision
type BoundingBox = Raylib_cs.BoundingBox

type Wave = Raylib_cs.Wave
type AudioStream = Raylib_cs.AudioStream
type Sound = Raylib_cs.Sound
type Music = Raylib_cs.Music

type VrDeviceInfo = Raylib_cs.VrDeviceInfo
type VrStereoConfig = Raylib_cs.VrStereoConfig

type FilePathList = Raylib_cs.FilePathList

type BlendMode = Raylib_cs.BlendMode
type CameraMode = Raylib_cs.CameraMode
type CameraProjection = Raylib_cs.CameraProjection
type ConfigFlags = Raylib_cs.ConfigFlags
type CubemapLayout = Raylib_cs.CubemapLayout
type DrawMode = Raylib_cs.DrawMode
type FontType = Raylib_cs.FontType
type FramebufferAttachTextureType = Raylib_cs.FramebufferAttachTextureType
type FramebufferAttachType = Raylib_cs.FramebufferAttachType
type GamepadAxis = Raylib_cs.GamepadAxis
type GamepadButton = Raylib_cs.GamepadButton
type Gesture = Raylib_cs.Gesture
type GlVersion = Raylib_cs.GlVersion
type KeyboardKey = Raylib_cs.KeyboardKey
type MaterialMapIndex = Raylib_cs.MaterialMapIndex
type MatrixMode = Raylib_cs.MatrixMode
type MouseButton = Raylib_cs.MouseButton
type MouseCursor = Raylib_cs.MouseCursor
type NPatchLayout = Raylib_cs.NPatchLayout
type PixelFormat = Raylib_cs.PixelFormat
type ShaderAttributeDataType = Raylib_cs.ShaderAttributeDataType
type ShaderLocationIndex = Raylib_cs.ShaderLocationIndex
type ShaderType = Raylib_cs.ShaderType
type ShaderUniformDataType = Raylib_cs.ShaderUniformDataType
type TextureFilter = Raylib_cs.TextureFilter
type TextureFilters = Raylib_cs.TextureFilters
type TextureWrap = Raylib_cs.TextureWrap
type TraceLogLevel = Raylib_cs.TraceLogLevel

[<Measure>] type R
[<Measure>] type G
[<Measure>] type B

[<Measure>] type H
[<Measure>] type S
[<Measure>] type V
[<Measure>] type Alpha

[<Measure>] type Contrast
[<Measure>] type Brightness
[<Measure>] type Threshold
[<Measure>] type Opacity
[<Measure>] type ColorInt
[<Measure>] type HexValue

[<Measure>] type X
[<Measure>] type Y
[<Measure>] type Z
[<Measure>] type OffsetX
[<Measure>] type OffsetY
[<Measure>] type Scale
[<Measure>] type ScaleX
[<Measure>] type ScaleY
[<Measure>] type Width
[<Measure>] type Height
[<Measure>] type Length
[<Measure>] type Radius
[<Measure>] type T

[<Measure>] type Zoom
[<Measure>] type Rotation
[<Measure>] type Angle
[<Measure>] type Degrees
[<Measure>] type DragAngle
[<Measure>] type PinchAngle
[<Measure>] type Thick
[<Measure>] type Roundness
[<Measure>] type Top
[<Measure>] type Bottom
[<Measure>] type HeaderSize

[<Measure>] type FontSize
[<Measure>] type Spacing
[<Measure>] type Codepoint
[<Measure>] type Position
[<Measure>] type GlyphIndex
[<Measure>] type GlyphCount
[<Measure>] type TileSize
[<Measure>] type Padding
[<Measure>] type PackMethod
[<Measure>] type CodepointIdx
[<Measure>] type UTF8Size
[<Measure>] type CodepointCount

[<Measure>] type Segments
[<Measure>] type Sides

[<Measure>] type Seconds
[<Measure>] type FPS
[<Measure>] type FrameTime
[<Measure>] type TimeSinceInit

[<Measure>] type KeyPressed
[<Measure>] type CharPressed

[<Measure>] type ScreenWidth
[<Measure>] type ScreenHeight
[<Measure>] type RenderWidth
[<Measure>] type RenderHeight
[<Measure>] type Monitor
[<Measure>] type MonitorCount
[<Measure>] type MonitorWidth
[<Measure>] type MonitorHeight
[<Measure>] type MonitorPhysicalWidth
[<Measure>] type MonitorPhysicalHeight
[<Measure>] type MonitorRefreshRate

[<Measure>] type ShaderLoc
[<Measure>] type Frames
[<Measure>] type Direction
[<Measure>] type Factor

[<Measure>] type Density

[<Measure>] type MouseWheelMove

[<Measure>] type GamepadIdx
[<Measure>] type GamepadAxisMovement
[<Measure>] type GamepadAxisCount
[<Measure>] type GamepadButtonNumer

[<Measure>] type TouchIdx
[<Measure>] type TouchPointId
[<Measure>] type TouchPointCount

[<Measure>] type Size
[<Measure>] type RadialSegments
[<Measure>] type Rings
[<Measure>] type Slices
[<Measure>] type Origin
[<Measure>] type BillboadSize
[<Measure>] type MeshIdx
[<Measure>] type MeshSize
[<Measure>] type MeshOffset
[<Measure>] type MaterialIdx

[<Measure>] type FrameIdx
[<Measure>] type SamplesCount
[<Measure>] type Volume
[<Measure>] type Pitch
[<Measure>] type Pan
[<Measure>] type InitSample
[<Measure>] type FinalSample
[<Measure>] type SampleRate
[<Measure>] type SampleSize
[<Measure>] type Channels
[<Measure>] type MusicLength
[<Measure>] type SeekTime
[<Measure>] type BufferSize

[<Measure>] type Distance

[<Measure>] type Determinant
[<Measure>] type Trace

[<Measure>] type PitchEuler
[<Measure>] type Yaw
[<Measure>] type Roll

module Conversions =
  let inline convInt<[<Measure>] 's, [<Measure>]'t> (i : int<'s>) = LanguagePrimitives.Int32WithMeasure<'t> (int i)
  let inline convInt64<[<Measure>] 's, [<Measure>]'t> (i : int64<'s>) = LanguagePrimitives.Int64WithMeasure<'t> (int64 i)
  let inline convFloat32<[<Measure>] 's, [<Measure>]'t> (f : float32<'s>) = LanguagePrimitives.Float32WithMeasure<'t> (float32 f)
  let inline convFloat<[<Measure>] 's, [<Measure>]'t> (f : float<'s>) = LanguagePrimitives.FloatWithMeasure<'t> (float f)
  

module Core =
  open Raylib_cs
  open type Raylib_cs.Raylib

  let inline InitWindow (width : int<Width>) (height : int<Height>) (title : string) = InitWindow (int width, int height, title)
  let inline CloseWindow () = CloseWindow ()
  let inline WindowShouldClose () : bool = WindowShouldClose () |> CBool.op_Implicit
  let inline IsWindowReady () : bool = IsWindowReady () |> CBool.op_Implicit
  let inline IsWindowFullscreen () : bool = IsWindowFullscreen () |> CBool.op_Implicit
  let inline IsWindowHidden () : bool = IsWindowHidden () |> CBool.op_Implicit
  let inline IsWindowMinimized () : bool = IsWindowMinimized () |> CBool.op_Implicit
  let inline IsWindowMaximized () : bool = IsWindowMaximized () |> CBool.op_Implicit
  let inline IsWindowFocused () : bool = IsWindowFocused () |> CBool.op_Implicit
  let inline IsWindowResized () : bool = IsWindowResized () |> CBool.op_Implicit
  let inline IsWindowState flag : bool = IsWindowState flag |> CBool.op_Implicit
  let inline SetWindowState flag : bool = SetWindowState flag |> CBool.op_Implicit
  let inline ClearWindowState flag = ClearWindowState flag
  let inline ToggleFullscreen () = ToggleFullscreen ()
  let inline MaximizeWindow () = MaximizeWindow ()
  let inline MinimizeWindow () = MinimizeWindow ()
  let inline RestoreWindow () = RestoreWindow ()
  let inline SetWindowIcon image = SetWindowIcon image
  let inline SetWindowIcons (images : Image []) = use ptr = fixed images in SetWindowIcons (ptr, images.Length)
  let inline SetWindowTitle (title : string) = SetWindowTitle title
  let inline SetWindowPosition (x : int<X>) (y : int<Y>) = SetWindowPosition (int x, int y)
  let inline SetWindowMonitor (monitor : int<Monitor>) = SetWindowMonitor (int monitor)
  let inline SetWindowMinSize (width : int<Width>) (height : int<Height>) = SetWindowMinSize (int width, int height)
  let inline SetWindowMaxSize (width : int<Width>) (height : int<Height>) = SetWindowMaxSize (int width, int height)
  let inline SetWindowSize (width : int<Width>) (height : int<Height>) = SetWindowSize (int width, int height)
  let inline SetWindowOpacity (opacity : float32<Opacity>) = SetWindowOpacity (float32 opacity)
  let inline SetWindowFocused () = SetWindowFocused ()
  let inline GetWindowHandle () = GetWindowHandle ()
  let inline GetScreenWidth () = GetScreenWidth () |> LanguagePrimitives.Int32WithMeasure<ScreenWidth>
  let inline GetScreenHeight () = GetScreenHeight () |> LanguagePrimitives.Int32WithMeasure<ScreenHeight>
  let inline GetRenderWidth () = GetRenderWidth () |> LanguagePrimitives.Int32WithMeasure<RenderWidth>
  let inline GetRenderHeight () = GetRenderHeight () |> LanguagePrimitives.Int32WithMeasure<RenderHeight>
  let inline GetMonitorCount () = GetMonitorCount () |> LanguagePrimitives.Int32WithMeasure<MonitorCount>
  let inline GetCurrentMonitor () = GetCurrentMonitor () |> LanguagePrimitives.Int32WithMeasure<Monitor>
  let inline GetMonitorPosition (monitor : int<Monitor>) = GetMonitorPosition (int monitor)
  let inline GetMonitorWidth (monitor : int<Monitor>) = GetMonitorWidth (int monitor) |> LanguagePrimitives.Int32WithMeasure<MonitorWidth>
  let inline GetMonitorHeight (monitor : int<Monitor>) = GetMonitorHeight (int monitor) |> LanguagePrimitives.Int32WithMeasure<MonitorHeight>
  let inline GetMonitorPhysicalWidth (monitor : int<Monitor>) = GetMonitorPhysicalWidth (int monitor) |> LanguagePrimitives.Int32WithMeasure<MonitorPhysicalWidth>
  let inline GetMonitorPhysicalHeight (monitor : int<Monitor>) = GetMonitorPhysicalHeight (int monitor) |> LanguagePrimitives.Int32WithMeasure<MonitorPhysicalHeight>
  let inline GetMonitorRefreshRate (monitor : int<Monitor>) = GetMonitorRefreshRate (int monitor) |> LanguagePrimitives.Int32WithMeasure<MonitorRefreshRate>
  let inline GetWindowPosition () = GetWindowPosition ()
  let inline GetWindowScaleDPI () = GetWindowScaleDPI ()
  let inline GetMonitorName (monitor : int<Monitor>) = GetMonitorName (int monitor) |> Utf8StringUtils.GetUTF8String
  let inline SetClipboardText (text : string) = SetClipboardText text
  let inline GetClipboardText () = GetClipboardText () |> Utf8StringUtils.GetUTF8String
  let inline EnableEventWaiting () = EnableEventWaiting ()
  let inline DisableEventWaiting () = DisableEventWaiting ()
  
  let inline ShowCursor () = ShowCursor ()
  let inline HideCursor () = HideCursor ()
  let inline IsCursorHidden () : bool = IsCursorHidden () |> CBool.op_Implicit
  let inline EnableCursor () = EnableCursor ()
  let inline DisableCursor () = DisableCursor ()
  let inline IsCursorOnScreen () : bool = IsCursorOnScreen () |> CBool.op_Implicit
  
  let inline ClearBackground color = ClearBackground color
  let inline BeginDrawing () = BeginDrawing ()
  let inline EndDrawing () = EndDrawing ()
  let inline BeginMode2D camera = BeginMode2D camera
  let inline EndMode2D () = EndMode2D ()
  let inline BeginMode3D camera = BeginMode3D camera
  let inline EndMode3D () = EndMode3D ()
  let inline BeginTextureMode target = BeginTextureMode target
  let inline EndTextureMode () = EndTextureMode ()
  let inline BeginBlendMode mode = BeginBlendMode mode
  let inline EndBlendMode () = EndBlendMode ()
  let inline BeginScissorMode (x : int<X>) (y : int<Y>) (width : int<Width>) (height : int<Height>) = BeginScissorMode (int x, int y, int width, int height)
  let inline EndScissorMode () = EndScissorMode ()
  let inline BeginVrStereoMode config = BeginVrStereoMode config
  let inline EndVrStereoMode () = EndVrStereoMode ()
  
  let inline LoadVrStereoConfig device = LoadVrStereoConfig device
  let inline UnloadVrStereoConfig config = UnloadVrStereoConfig config
  
  let inline LoadShader (vs : string) (fs : string) = LoadShader (vs, fs)
  let inline LoadeShaderFromMemory (vs : string) (fs : string) = LoadShaderFromMemory (vs, fs)
  let inline IsShaderReady shader : bool = IsShaderReady shader |> CBool.op_Implicit
  let inline GetShaderLocation shader (uniformName : string) = GetShaderLocation (shader, uniformName) |> LanguagePrimitives.Int32WithMeasure<ShaderLoc>
  let inline GetShaderLocationAttrib shader (attribName : string) = GetShaderLocationAttrib (shader, attribName) |> LanguagePrimitives.Int32WithMeasure<ShaderLoc>
  let inline SetShaderValue shader (loc : int<ShaderLoc>) (values : _ []) uniformType  = SetShaderValue (shader, int loc, values, uniformType)
  let inline SetShaderValueV shader (loc : int<ShaderLoc>) (values : _ []) uniformType = SetShaderValueV (shader, int loc, values, uniformType, values.Length)
  let inline SetShaderValueMatrix shader (loc : int<ShaderLoc>) (mat : Matrix) = SetShaderValueMatrix (shader, int loc, mat)
  let inline SetShaderValueTexture shader (loc : int<ShaderLoc>) texture = SetShaderValueTexture (shader, int loc, texture)
  let inline UnloadShader shader = UnloadShader shader
  
  let inline GetMouseRay mousePosition camera = GetMouseRay (mousePosition, camera)
  let inline GetCameraMatrix camera = GetCameraMatrix camera
  let inline GetCameraMatrix2D camera = GetCameraMatrix2D camera
  let inline GetWorldToScreen position camera = GetWorldToScreen (position, camera)
  let inline GetWorldToScreenEx position camera (width : int<Width>) (height : int<Height>) = GetWorldToScreenEx (position, camera, int width, int height)
  let inline GetWorldToScreen2D position camera = GetWorldToScreen2D (position, camera)
  
  let inline SetTargetFPS (fps : int<FPS>) = SetTargetFPS (int fps)
  let inline GetFrameTime () = GetFrameTime () |> LanguagePrimitives.Float32WithMeasure<FrameTime>
  let inline GetTime () = GetTime () |> LanguagePrimitives.FloatWithMeasure<TimeSinceInit>
  let inline GetFPS () = GetFPS () |> LanguagePrimitives.Int32WithMeasure<FPS>
  
  let inline SwapScreenBuffer () = SwapScreenBuffer ()
  let inline PollInputEvents () = PollInputEvents ()
  let inline WaitTime (seconds : double<Seconds>) = WaitTime (double seconds)
  
  let inline SetRandomSeed seed = SetRandomSeed seed
  let inline GetRandomValue min max = GetRandomValue (min, max)
  
  let inline TakeScreenshot (fileName : string) = TakeScreenshot fileName
  let inline SetConfigFlags flags = SetConfigFlags flags
  let inline OpenURL (url : string) = OpenURL url
  
  let inline IsKeyPressed key : bool = IsKeyPressed key |> CBool.op_Implicit
  let inline IsKeyPressedRepeat key : bool = IsKeyPressedRepeat key |> CBool.op_Implicit
  let inline IsKeyDown key : bool = IsKeyDown key |> CBool.op_Implicit
  let inline IsKeyReleased key : bool = IsKeyReleased key |> CBool.op_Implicit
  let inline IsKeyUp key : bool = IsKeyUp key |> CBool.op_Implicit
  let inline GetKeyPressed () = GetKeyPressed () |> LanguagePrimitives.Int32WithMeasure<KeyPressed>
  let inline GetCharPressed () = GetCharPressed () |> LanguagePrimitives.Int32WithMeasure<CharPressed>
  let inline SetExitKey key = SetExitKey key
  
  let inline IsGamepadAvailable (gamepad : int<GamepadIdx>) : bool = IsGamepadAvailable (int gamepad) |> CBool.op_Implicit
  let inline GetGamepadName (gamepad : int<GamepadIdx>) = GetGamepadName (int gamepad) |> Utf8StringUtils.GetUTF8String
  let inline IsGamepadButtonPressed (gamepad : int<GamepadIdx>) button : bool = IsGamepadButtonPressed (int gamepad, button) |> CBool.op_Implicit
  let inline IsGamepadButtonDown (gamepad : int<GamepadIdx>) button : bool = IsGamepadButtonDown (int gamepad, button) |> CBool.op_Implicit
  let inline IsGamepadButtonReleased (gamepad : int<GamepadIdx>) button : bool = IsGamepadButtonReleased (int gamepad, button) |> CBool.op_Implicit
  let inline IsGamepadButtonUp (gamepad : int<GamepadIdx>) button : bool = IsGamepadButtonUp (int gamepad, button) |> CBool.op_Implicit
  let inline GetGamepadButtonPressed () = GetGamepadButtonPressed () |> LanguagePrimitives.Int32WithMeasure<GamepadButtonNumer>
  let inline GetGamepadAxisCount (gamepad : int<GamepadIdx>) = GetGamepadAxisCount (int gamepad) |> LanguagePrimitives.Int32WithMeasure<GamepadAxisCount>
  let inline GetGamepadAxisMovement (gamepad : int<GamepadIdx>) axis = GetGamepadAxisMovement (int gamepad, axis) |> LanguagePrimitives.Float32WithMeasure<GamepadAxisMovement>
  let inline SetGamepadMappings (mappings : string) = SetGamepadMappings mappings
  
  let inline IsMouseButtonPressed button : bool = IsMouseButtonPressed button |> CBool.op_Implicit
  let inline IsMouseButtonDown button : bool = IsMouseButtonDown button |> CBool.op_Implicit
  let inline IsMouseButtonReleased button : bool = IsMouseButtonReleased button |> CBool.op_Implicit
  let inline IsMouseButtonUp button : bool = IsMouseButtonUp button |> CBool.op_Implicit
  let inline GetMouseX () = GetMouseX () |> LanguagePrimitives.Int32WithMeasure<X>
  let inline GetMouseY () = GetMouseY () |> LanguagePrimitives.Int32WithMeasure<Y>
  let inline GetMousePosition () = GetMousePosition ()
  let inline GetMouseDelta () = GetMouseDelta ()
  let inline SetMousePosition (x : int<X>) (y : int<Y>) = SetMousePosition (int x, int y)
  let inline SetMouseOffset (offsetX : int<OffsetX>) (offsetY : int<OffsetY>) = SetMouseOffset (int offsetX, int offsetY)
  let inline SetMouseScale (scaleX : float32<ScaleX>) (scaleY : float32<ScaleY>) = SetMouseScale (float32 scaleX, float32 scaleY)
  let inline GetMouseWheelMove () = GetMouseWheelMove () |> LanguagePrimitives.Float32WithMeasure<MouseWheelMove>
  let inline GetMouseWheelMoveV () = GetMouseWheelMoveV ()
  let inline SetMouseCursor cursor = SetMouseCursor cursor
  
  let inline GetTouchX () = GetTouchX () |> LanguagePrimitives.Int32WithMeasure<X>
  let inline GetTouchY () = GetTouchY () |> LanguagePrimitives.Int32WithMeasure<Y>
  let inline GetTouchPosition (index : int<TouchIdx>) = GetTouchPosition (int index)
  let inline GetTouchPointId (index : int<TouchIdx>) = GetTouchPointId (int index) |> LanguagePrimitives.Int32WithMeasure<TouchPointId>
  let inline GetTouchPointCount () = GetTouchPointCount () |> LanguagePrimitives.Int32WithMeasure<TouchPointCount>
  
  let inline SetGesturesEnabled gestureFlags = SetGesturesEnabled gestureFlags
  let inline IsGestureDetected gesture : bool = IsGestureDetected gesture |> CBool.op_Implicit
  let inline GetGestureDetected () = GetGestureDetected ()
  let inline GetGestureHoldDuration () = GetGestureHoldDuration () |> LanguagePrimitives.Float32WithMeasure<Seconds>
  let inline GetGestureDragVector () = GetGestureDragVector ()
  let inline GetGestureDragAngle () = GetGestureDragAngle () |> LanguagePrimitives.Float32WithMeasure<DragAngle>
  let inline GetGesturePinchVector () = GetGesturePinchVector ()
  let inline GetGesturePinchAngle () = GetGesturePinchAngle () |> LanguagePrimitives.Float32WithMeasure<PinchAngle>
  
  let inline UpdateCamera camera mode = UpdateCamera (ref camera, mode)
  let inline UpdateCameraPro camera movement rotation (zoom : float32<Zoom>) = UpdateCameraPro (ref camera, movement, rotation, float32 zoom)
  
    
module Shapes =
  open Raylib_cs
  open type Raylib_cs.Raylib

  let inline SetShapesTexture texture source = SetShapesTexture (texture, source)
  
  let inline DrawPixel (x : int<X>) (y : int<Y>) color = DrawPixel (int x, int y, color)
  let inline DrawPixelV position color = DrawPixelV (position, color)
  let inline DrawLine (x : int<X>) (y : int<Y>) (x2 : int<X>) (y2 : int<Y>) color = DrawLine (int x, int y, int x2, int y2, color)
  let inline DrawLineV start end_ color = DrawLineV (start, end_, color)
  let inline DrawLineEx start end_ (thick : float32<Thick>) color = DrawLineEx (start, end_, float32 thick, color)
  let inline DrawLineStrip (points : _ []) color = DrawLineStrip (points, points.Length, color)
  let inline DrawLineBezier start end_ (thick : float32<Thick>) color = DrawLineBezier (start, end_, float32 thick, color)
  let inline DrawCircle (x : int<X>) (y : int<Y>) (radius : float32<Radius>) color = DrawCircle (int x, int y, float32 radius, color)
  let inline DrawCircleSector center (radius : float32<Radius>) (startAngle : float32<Angle>) (endAngle : float32<Angle>) (segments : int<Segments>) color = DrawCircleSector (center, float32  radius, float32 startAngle, float32 endAngle, int segments, color)
  let inline DrawCircleSectorLines center (radius : float32<Radius>) (startAngle : float32<Angle>) (endAngle : float32<Angle>) (segments : int<Segments>) color = DrawCircleSectorLines (center, float32 radius, float32 startAngle, float32 endAngle, int segments, color)
  let inline DrawCircleGradient (x : int<X>) (y : int<Y>) (radius : float32<Radius>) color1 color2 = DrawCircleGradient (int x, int y, float32 radius, color1, color2)
  let inline DrawCircleV center (radius : float32<Radius>) color = DrawCircleV (center, float32 radius, color)
  let inline DrawCircleLines (x : int<X>) (y : int<Y>) (radius : float32<Radius>) color = DrawCircleLines (int x, int y, float32 radius, color)
  let inline DrawCircleLinesV center (radius : float32<Radius>) color = DrawCircleLinesV (center, float32 radius, color)
  let inline DrawEllipse (x : int<X>) (y : int<Y>) (radiusH : float32<Radius>) (radiusV : float32<Radius>) color = DrawEllipse (int x, int y, float32 radiusH, float32 radiusV, color)
  let inline DrawEllipseLines (x : int<X>) (y : int<Y>) (radiusH : float32<Radius>) (radiusV : float32<Radius>) color = DrawEllipseLines (int x, int y, float32 radiusH, float32 radiusV, color)
  let inline DrawRing center (innerRadius : float32<Radius>) (outerRadius : float32<Radius>) (startAngle : float32<Angle>) (endAngle : float32<Angle>) (segments : int<Segments>) color = DrawRing (center, float32 innerRadius, float32 outerRadius, float32 startAngle, float32 endAngle, int segments, color)
  let inline DrawRingLines center (innerRadius : float32<Radius>) (outerRadius : float32<Radius>) (startAngle : float32<Angle>) (endAngle : float32<Angle>) (segments : int<Segments>) color = DrawRingLines (center, float32 innerRadius, float32 outerRadius, float32 startAngle, float32 endAngle, int segments, color)
  let inline DrawRectangle (x : int<X>) (y : int<Y>) (width : int<Width>) (height : int<Height>) color = DrawRectangle (int x, int y, int width, int height, color)
  let inline DrawRectangleV position size color = DrawRectangleV (position, size, color)
  let inline DrawRectangleRec rect color = DrawRectangleRec (rect, color)
  let inline DrawRectanglePro rect origin (rotation : float32<Rotation>) color = DrawRectanglePro (rect, origin, float32 rotation, color)
  let inline DrawRectangleGradientV (x : int<X>) (y : int<Y>) (width : int<Width>) (height : int<Height>) color1 color2 = DrawRectangleGradientV (int x, int y, int width, int height, color1, color2)
  let inline DrawRectangleGradientH (x : int<X>) (y : int<Y>) (width : int<Width>) (height : int<Height>) color1 color2 = DrawRectangleGradientH (int x, int y, int width, int height, color1, color2)
  let inline DrawRectangleGradientEx rect col1 col2 col3 col4 = DrawRectangleGradientEx (rect, col1, col2, col3, col4)
  let inline DrawRectangleLines (x : int<X>) (y : int<Y>) (width : int<Width>) (height : int<Height>) color = DrawRectangleLines (int x, int y, int width, int height, color)
  let inline DrawRectangleLinesEx rect (thick : float32<Thick>) color = DrawRectangleLinesEx (rect, float32 thick, color)
  let inline DrawRectangleRounded rect (roundness : float32<Roundness>) (segments : int<Segments>) color = DrawRectangleRounded (rect, float32 roundness, int segments, color)
  let inline DrawRectangleRoundedLines rect (roundness : float32<Roundness>) (segments : int<Segments>) (thick : float32<Thick>) color = DrawRectangleRoundedLines (rect, float32 roundness, int segments, float32 thick, color)
  let inline DrawTriangle v1 v2 v3 color = DrawTriangle (v1, v2, v3, color)
  let inline DrawTriangleLines v1 v2 v3 color = DrawTriangleLines (v1, v2, v3, color)
  let inline DrawTriangleFan (points : _ []) color = DrawTriangleFan (points, points.Length, color)
  let inline DrawTriangleStrip (points : _ []) color = DrawTriangleStrip (points, points.Length, color)
  let inline DrawPoly center (sides : int<Sides>) (radius : float32<Radius>) (rotation : float32<Rotation>) color = DrawPoly (center, int sides, float32 radius, float32 rotation, color)
  let inline DrawPolyLines center (sides : int<Sides>) (radius : float32<Radius>) (rotation : float32<Rotation>) color = DrawPolyLines (center, int sides, float32 radius, float32 rotation, color)
  let inline DrawPolyLinesEx center (sides : int<Sides>) (radius : float32<Radius>) (rotation : float32<Rotation>) (thick : float32<Thick>) color = DrawPolyLinesEx (center, int sides, float32 radius, float32 rotation, float32 thick, color)
    
  let inline DrawSplineLinear (points : _ []) (thick : float32<Thick>) color = DrawSplineLinear (points, points.Length, float32 thick, color)
  let inline DrawSplineBasis (points : _ []) (thick : float32<Thick>) color = DrawSplineBasis (points, points.Length, float32 thick, color)
  let inline DrawSplineCatmullRom (points : _ []) (thick : float32<Thick>) color = DrawSplineCatmullRom (points, points.Length, float32 thick, color)
  let inline DrawSplineBezierQuadratic (points : _ []) (thick : float32<Thick>) color = DrawSplineBezierQuadratic (points, points.Length, float32 thick, color)
  let inline DrawSplineBezierCubic (points : _ []) (thick : float32<Thick>) color = DrawSplineBezierCubic (points, points.Length, float32 thick, color)
  let inline DrawSplineSegmentLinear p1 p2 (thick : float32<Thick>) color = DrawSplineSegmentLinear (p1, p2, float32 thick, color)
  let inline DrawSplineSegmentBasis p1 p2 p3 p4 (thick : float32<Thick>) color = DrawSplineSegmentBasis (p1, p2, p3, p4, float32 thick, color)
  let inline DrawSplineSegmentCatmullRom p1 p2 p3 p4 (thick : float32<Thick>) color = DrawSplineSegmentCatmullRom (p1, p2, p3, p4, float32 thick, color)
  let inline DrawSplineSegmentBezierQuadratic p1 p2 p3 (thick : float32<Thick>) color = DrawSplineSegmentBezierQuadratic (p1, p2, p3, float32 thick, color)
  let inline DrawSplineSegmentBezierCubic p1 p2 p3 p4 (thick : float32<Thick>) color = DrawSplineSegmentBezierCubic (p1, p2, p3, p4, float32 thick, color)
  
  let inline GetSplinePointLinear p1 p2 (t : float32<T>) = GetSplinePointLinear (p1, p2, float32 t)
  let inline GetSplinePointBasis p1 p2 p3 p4 (t : float32<T>) = GetSplinePointBasis (p1, p2, p3, p4, float32 t)
  let inline GetSplinePointCatmullRom p1 p2 p3 p4 (t : float32<T>) = GetSplinePointCatmullRom (p1, p2, p3, p4, float32 t)
  let inline GetSplinePointBezierQuad p1 p2 p3 (t : float32<T>) = GetSplinePointBezierQuad (p1, p2, p3, float32 t)
  let inline GetSplinePointBezierCubic p1 p2 p3 p4 (t : float32<T>) = GetSplinePointBezierCubic (p1, p2, p3, p4, float32 t)
  
  let inline CheckCollisionRecs rect1 rect2 : bool = CheckCollisionRecs (rect1, rect2) |> CBool.op_Implicit
  let inline CheckCollisionCircles center1 (radius1 : float32<Radius>) center2 (radius2 : float32<Radius>) : bool = CheckCollisionCircles (center1, float32 radius1, center2, float32 radius2) |> CBool.op_Implicit
  let inline CheckCollisionCircleRec center (radius : float32<Radius>) rect : bool = CheckCollisionCircleRec (center, float32 radius, rect) |> CBool.op_Implicit
  let inline CheckCollisionPointRec point rect : bool = CheckCollisionPointRec (point, rect) |> CBool.op_Implicit
  let inline CheckCollisionPointCircle point center (radius : float32<Radius>) : bool = CheckCollisionPointCircle (point, center, float32 radius) |> CBool.op_Implicit
  let inline CheckCollisionPointTriangle point p1 p2 p3 : bool = CheckCollisionPointTriangle (point, p1, p2, p3) |> CBool.op_Implicit
  let inline CheckCollisionPointPoly point (points : _ []) : bool = use ptr = fixed points in CheckCollisionPointPoly (point, ptr, points.Length) |> CBool.op_Implicit
  let inline CheckCollisionLines start1 end1 start2 end2 collisionPoint : bool = CheckCollisionLines (start1, end1, start2, end2, ref collisionPoint) |> CBool.op_Implicit
  let inline CheckCollisionPointLine point start end_ (thick : int<Thick>) : bool = CheckCollisionPointLine (point, start, end_, int thick) |> CBool.op_Implicit
  let inline GetCollisionRec rec1 rec2 = GetCollisionRec (rec1, rec2)

module Textures =
  open Raylib_cs
  open type Raylib_cs.Raylib

  let inline LoadImage (fileName : string) = LoadImage fileName
  let inline LoadImageRaw (fileName : string) (width : int<Width>) (height : int<Height>) format (headerSize : int<HeaderSize>) = LoadImageRaw (fileName, int width, int height, format, int headerSize)
  let inline LoadImageSvg (fileName : string) (width : int<Width>) (height : int<Height>) = LoadImageSvg (fileName, int width, int height)
  let inline LoadImageAnim (fileName : string) (frames : int<Frames>) = LoadImageAnim (fileName, ref (int frames))
  // let inline LoadImageFromMemory (fileType : string) (fileData : byte []) dataSize =
  //   let ft = Encoding.UTF8.GetBytes (fileType + "\0")
  //   let nativeFt = Marshal.AllocHGlobal ft.Length
  //   Marshal.Copy (ft, 0, nativeFt, ft.Length)
  //   let nativeFd = Marshal.AllocHGlobal fileData.Length
  //   Marshal.Copy (fileData, 0, nativeFd, fileData.Length)
  //   LoadImageFromMemory (nativeFt.ToInt64 () |> nativeint |> NativePtr.ofNativeInt, nativeFd  |> nativeint |> NativePtr.ofNativeInt, dataSize)
  let inline LoadImageFromTexture texture = LoadImageFromTexture texture
  let inline LoadImageFromScreen () = LoadImageFromScreen ()
  let inline IsImageReady image : bool = IsImageReady image |> CBool.op_Implicit
  let inline UnloadImage image = UnloadImage image
  let inline ExportImage image (fileName : string) = ExportImage (image, fileName)
  // let inline ExportImageToMemory image (fileType : string) (fileSize : int) =
  //   ExportImageToMemory (image, fileType, fileSize)
  let inline ExportImageAsCode image (fileName : string) = ExportImageAsCode (image, fileName)
  
  let inline GenImageColor (width : int<Width>) (height : int<Height>) color = GenImageColor (int width, int height, color)
  let inline GenImageGradientLinear (width : int<Width>) (height : int<Height>) (direction : int<Direction>) color1 color2 = GenImageGradientLinear (int width, int height, int direction, color1, color2)
  let inline GenImageGradientRadial (width : int<Width>) (height : int<Height>) (density : float32<Density>) innerColor outerColor = GenImageGradientRadial (int width, int height, float32 density, innerColor, outerColor)
  let inline GenImageGradientSquare (width : int<Width>) (height : int<Height>) (density : float32<Density>) color1 color2 = GenImageGradientSquare (int width, int height, float32 density, color1, color2)
  let inline GenImageChecked (width : int<Width>) (height : int<Height>) (x : int<X>) (y : int<Y>) col1 col2 = GenImageChecked (int width, int height, int x, int y, col1, col2)
  let inline GenImageWhiteNoise (width : int<Width>) (height : int<Height>) (factor : float32<Factor>) = GenImageWhiteNoise (int width, int height, float32 factor)
  let inline GenImagePerlinNoise (width : int<Width>) (height : int<Height>) (offsetX : int<OffsetX>) (offsetY : int<OffsetY>) (scale : float32<Scale>) = GenImagePerlinNoise (int width, int height, int offsetX, int offsetY, float32 scale)
  let inline GenImageCellular (width : int<Width>) (height : int<Height>) (tileSize : int<TileSize>) = GenImageCellular (int width, int height, int tileSize)
  let inline GenImageText (width : int<Width>) (height : int<Height>) (text : string) = GenImageText (int width, int height, text)
  
  let inline ImageCopy image = ImageCopy image
  let inline ImageFromImage image rect = ImageFromImage (image, rect)
  let inline ImageText (text : string) (fontSize : int<FontSize>) color = ImageText (text, int fontSize, color)
  let inline ImageTextEx font (text : string) (fontSize : float32<FontSize>) (spacing : float32<Spacing>) tint = ImageTextEx (font, text, float32 fontSize, float32 spacing, tint)
  let inline ImageFormat image newFormat = ImageFormat (ref image, newFormat)
  let inline ImageToPOT image fill = ImageToPOT (ref image, fill)
  let inline ImageCrop image crop = ImageCrop (ref image, crop)
  let inline ImageAlphaCrop image (threshold : float<Threshold>) = ImageAlphaCrop (ref image, float32 threshold)
  let inline ImageAlphaClear image color (threshold : float<Threshold>) = ImageAlphaClear (ref image, color, float32 threshold)
  let inline ImageAlphaMask image alphaMask = ImageAlphaMask (ref image, alphaMask)
  let inline ImageAlphaPremultiply image = ImageAlphaPremultiply (ref image)
  let inline ImageBlurGaussian image (radius : int<Radius>) = ImageBlurGaussian (ref image, int radius)
  let inline ImageResize image (width : int<Width>) (height : int<Height>) = ImageResize (ref image, int width, int height)
  let inline ImageResizeNN image (width : int<Width>) (height : int<Height>) = ImageResizeNN (ref image, int width, int height)
  let inline ImageResizeCanvas image (width : int<Width>) (height : int<Height>) (offsetX : int<OffsetX>) (offsetY : int<OffsetY>) color = ImageResizeCanvas (ref image, int width, int height, int offsetX, int offsetY, color)
  let inline ImageMipmaps image = ImageMipmaps (ref image)
  let inline ImageDither image (r : int<R>) (g : int<G>) (b : int<B>) (a : int<Alpha>) = ImageDither (ref image, int r, int g, int b, int a)
  let inline ImageFlipVertical image = ImageFlipVertical (ref image)
  let inline ImageFlipHorizontal image = ImageFlipHorizontal (ref image)
  let inline ImageRotate image (deg : int<Degrees>) = ImageRotate (ref image, int deg)
  let inline ImageRotateCW image = ImageRotateCW (ref image)
  let inline ImageRotateCCW image = ImageRotateCCW (ref image)
  let inline ImageColorTint image color = ImageColorTint (ref image, color)
  let inline ImageColorInvert image = ImageColorInvert (ref image)
  let inline ImageColorGrayscale image = ImageColorGrayscale (ref image)
  let inline ImageColorContrast image (contrast : float32<Contrast>) = ImageColorContrast (ref image, float32 contrast)
  let inline ImageColorBrightness image (brightness : int<Brightness>) = ImageColorBrightness (ref image, int brightness)
  let inline ImageColorReplace image color replace = ImageColorReplace (ref image, color, replace)
  let inline GetImageAlphaBorder image (threshold : float32<Threshold>) = GetImageAlphaBorder (image, float32 threshold)
  let inline GetImageColor image (x : int<X>) (y : int<Y>) = GetImageColor (image, int x, int y)
  
  let inline ImageClearBackground image color = ImageClearBackground (ref image, color)
  let inline ImageDrawPixel image (x : int<X>) (y : int<Y>) color = ImageDrawPixel (ref image, int x, int y, color)
  let inline ImageDrawPixelV image position color = ImageDrawPixelV (ref image, position, color)
  let inline ImageDrawLine image (x : int<X>) (y : int<Y>) (x2 : int<X>) (y2 : int<Y>) color = ImageDrawLine (ref image, int x, int y, int x2, int y2, color)
  let inline ImageDrawLineV image start end_ color = ImageDrawLineV (ref image, start, end_, color)
  let inline ImageDrawCircle image (x : int<X>) (y : int<Y>) (radius : int<Radius>) color = ImageDrawCircle (ref image, int x, int y, int radius, color)
  let inline ImageDrawCircleV image center (radius : int<Radius>) color = ImageDrawCircleV (ref image, center, int radius, color)
  let inline ImageDrawCircleLines (image : Image []) (x : int<X>) (y : int<Y>) (radius : int<Radius>) color = use ptr = fixed image in ImageDrawCircleLines (ptr, int x, int y, int radius, color)
  let inline ImageDrawCircleLinesV (image : Image []) center (radius : int<Radius>) color = use ptr = fixed image in ImageDrawCircleLinesV (ptr, center, int radius, color)
  let inline ImageDrawRectangle image (x : int<X>) (y : int<Y>) (width : int<Width>) (height : int<Height>) color = ImageDrawRectangle (ref image, int x, int y, int width, int height, color)
  let inline ImageDrawRectangleV image position size color = ImageDrawRectangleV (ref image, position, size, color)
  let inline ImageDrawRectangleRec image rect color = ImageDrawRectangleRec (ref image, rect, color)
  let inline ImageDrawRectangleLines image rect (thick : int<Thick>) color = ImageDrawRectangleLines (ref image, rect, int thick, color)
  let inline ImageDraw dst src srcRect dstRect color = ImageDraw (ref dst, src, srcRect, dstRect, color)
  let inline ImageDrawText image (text : string) (x : int<X>) (y : int<Y>) (fontSize : int<FontSize>) color = ImageDrawText (ref image, text, int x, int y, int fontSize, color)
  let inline ImageDrawTextEx dst font text pos (fontSize : int<FontSize>) (spacing : float32<Spacing>) tint = ImageDrawTextEx (ref dst, font, text, pos, int fontSize, float32 spacing, tint)
  
  let inline LoadTexture (fileName : string) = LoadTexture fileName
  let inline LoadTextureFromImage image = LoadTextureFromImage image
  let inline LoadTextureCubemap image layout = LoadTextureCubemap (image, layout)
  let inline LoadRenderTexture (width : int<Width>) (height : int<Height>) = LoadRenderTexture (int width, int height)
  let inline IsTextureReady texture : bool = IsTextureReady texture |> CBool.op_Implicit
  let inline UnloadTexture texture = UnloadTexture texture
  let inline IsRenderTextureReady target : bool = IsRenderTextureReady target |> CBool.op_Implicit
  let inline UnloadRenderTexture target = UnloadRenderTexture target
  let inline UpdateTexture texture pixels = UpdateTexture (texture, pixels)
  let inline UpdateTextureRec texture rect pixels = UpdateTextureRec (texture, rect, pixels)
  
  let inline GenTextureMipmaps texture = GenTextureMipmaps (ref texture)
  let inline SetTextureFilter texture filterMode = SetTextureFilter (texture, filterMode)
  let inline SetTextureWrap texture wrapMode = SetTextureWrap (texture, wrapMode)
  
  let inline DrawTexture texture (x : int<X>) (y : int<Y>) color = DrawTexture (texture, int x, int y, color)
  let inline DrawTextureV texture position color = DrawTextureV (texture, position, color)
  let inline DrawTextureEx texture position (rotation : float32<Rotation>) (scale : float32<Scale>) color = DrawTextureEx (texture, position, float32 rotation, float32 scale, color)
  let inline DrawTextureRec texture source position color = DrawTextureRec (texture, source, position, color)
  let inline DrawTexturePro texture source dest origin (rotation : float32<Rotation>) color = DrawTexturePro (texture, source, dest, origin, float32 rotation, color)
  let inline DrawTextureNPatch texture nPatchInfo dest origin (rotation : float32<Rotation>) color = DrawTextureNPatch (texture, nPatchInfo, dest, origin, float32 rotation, color)
  
  let inline Fade color (alpha : float32<Alpha>) = Fade (color, float32 alpha)
  let inline ColorToInt color = ColorToInt color |> LanguagePrimitives.Int32WithMeasure<ColorInt>
  let inline ColorNormalize color = ColorNormalize color
  let inline ColorFromNormalized normalized = ColorFromNormalized normalized
  let inline ColorToHSV color = ColorToHSV color |> fun hsv -> {| H = hsv.X |> LanguagePrimitives.Float32WithMeasure<H>; S = hsv.Y |> LanguagePrimitives.Float32WithMeasure<S>; V = hsv.Z |> LanguagePrimitives.Float32WithMeasure<V> |}
  let inline ColorFromHSV (h : float32<H>) (s : float32<S>) (v : float32<V>) = ColorFromHSV (float32 h, float32 s, float32 v)
  let inline ColorTint color tint = ColorTint (color, tint)
  let inline ColorBrightness color (brightness : float32<Brightness>) = ColorBrightness (color, float32 brightness)
  let inline ColorContrast color (contrast : float32<Contrast>) = ColorContrast (color, float32 contrast)
  let inline ColorAlpha color (alpha : float32<Alpha>) = ColorAlpha (color, float32 alpha)
  let inline ColorAlphaBlend dst src tint = ColorAlphaBlend (dst, src, tint)
  let inline GetColor (hexValue : uint32<HexValue>) = GetColor (uint32 hexValue)
  let inline GetPixelColor srcPtr format = GetPixelColor (srcPtr, format)
  let inline SetPixelColor dstPtr color format = SetPixelColor (dstPtr, color, format)
  let inline GetPixelDataSize (width : int<Width>) (height : int<Height>) format = GetPixelDataSize (int width, int height, format)
  
module Text =
  open type Raylib_cs.Raylib

  let inline GetFontDefault () = GetFontDefault ()
  let inline LoadFont (fileName : string) = LoadFont fileName
  let inline LoadFontEx (fileName : string) (fontSize : int<FontSize>) (codepoints : int<Codepoint> []) = LoadFontEx (fileName, int fontSize, codepoints |> Array.map int, codepoints.Length)
  let inline LoadFontFromImage image colorKey firstChar = LoadFontFromImage (image, colorKey, firstChar) // TODO give this a measure
  //let inline LoadFontFromMemory (fileType : string) (fileData : byte []) dataSize fontSize charsCount fontChars = LoadFontFromMemory (fileType, fileData, dataSize, fontSize, charsCount, fontChars)
  let inline GenImageFontAtlas glyphs glyphRecs (glyphCount : int<GlyphCount>) (fontSize : int<FontSize>) (padding : int<Padding>) (packMethod : int<PackMethod>) = GenImageFontAtlas (glyphs, glyphRecs, int glyphCount, int fontSize, int padding, int packMethod)
  let inline UnloadFontData glyphs (glyphCount : int<GlyphCount>) = UnloadFontData (glyphs, int glyphCount)
  let inline UnloadFont font = UnloadFont font
  //let inline ExportFontAsCode font (fileName : string) = ExportFontAsCode (font, fileName)
  
  let inline DrawFPS (x : int<X>) (y : int<Y>) = DrawFPS (int x, int y)
  let inline DrawText (text : string) (x : int<X>) (y : int<Y>) (fontSize : int<FontSize>) color = DrawText (text, int x, int y, int fontSize, color)
  let inline DrawTextEx font (text : string) position (fontSize : float32<FontSize>) (spacing : float32<Spacing>) tint = DrawTextEx (font, text, position, float32 fontSize, float32 spacing, tint)
  let inline DrawTextPro font (text : string) position origin (rotation : float32<Rotation>) (fontSize : float32<FontSize>) (spacing : float32<Spacing>) tint = DrawTextPro (font, text, position, origin, float32 rotation, float32 fontSize, float32 spacing, tint)
  let inline DrawTextCodepoint font (codepoint : int<Codepoint>) position (fontSize : float32<FontSize>) color = DrawTextCodepoint (font, int codepoint, position, float32 fontSize, color)
  let inline DrawTextCodepoints font (codepoints : int<Codepoint> []) position (fontSize : float32<FontSize>) (spacing : float32<Spacing>) color =
    use ptr = fixed (codepoints |> Array.map int)
    DrawTextCodepoints (font, ptr, codepoints.Length, position, float32 fontSize, float32 spacing, color)
  
  let inline SetTextLineSpacing (spacing : int<Spacing>) = SetTextLineSpacing (int spacing)
  let inline MeasureText (text : string) (fontSize : int<FontSize>) = MeasureText (text, int fontSize) |> LanguagePrimitives.Int32WithMeasure<Width>
  let inline MeasureTextEx font (text : string) (fontSize : float32<FontSize>) (spacing : float32<Spacing>) = MeasureTextEx (font, text, float32 fontSize, float32 spacing)
  let inline GetGlyphIndex font (codepoint : int<Codepoint>) = GetGlyphIndex (font, int codepoint) |> LanguagePrimitives.Int32WithMeasure<GlyphIndex>
  let inline GetGlyphInfo font (index : int<GlyphIndex>) = GetGlyphInfo (font, int index)
  let inline GetGlyphAtlasRec font (index : int<GlyphIndex>) = GetGlyphAtlasRec (font, int index)
  
  let inline LoadUTF8 (codepoints : int<Codepoint> []) = LoadUTF8 (codepoints |> Array.map int, codepoints.Length)
  let inline UnloadUTF8 text = UnloadUTF8 text
  let inline LoadCodepoints (text : string) count = LoadCodepoints (text, ref count) |> Array.map LanguagePrimitives.Int32WithMeasure<Codepoint>
  let inline UnloadCodepoints codepoints = UnloadCodepoints codepoints
  let inline GetCodepointCount (text : string) = GetCodepointCount text |> LanguagePrimitives.Int32WithMeasure<CodepointCount>
  let inline GetCodepoint (text : string) (position : int<CodepointIdx>) = GetCodepoint (text, ref (int position)) |> LanguagePrimitives.Int32WithMeasure<Codepoint>
  //let inline GetCodepointNext (text : string) position = GetCodepointNext (text, position)
  //let inline GetCodepointPrevious (text : string) position = GetCodepointPrevious (text, position)
  let inline CodepointToUTF8 (codepoint : int<Codepoint>) (utf8Size : int<UTF8Size>) = CodepointToUTF8 (int codepoint, ref (int utf8Size))
  
  
  
module Models =
  open Raylib_cs
  open type Raylib_cs.Raylib

  let inline DrawLine3D start end_ color = DrawLine3D (start, end_, color)
  let inline DrawPoint3D position color = DrawPoint3D (position, color)
  let inline DrawCircle3D center (radius : float32<Radius>) axis (angle : float32<Angle>) color = DrawCircle3D (center, float32 radius, axis, float32 angle, color)
  let inline DrawTriangle3D v1 v2 v3 color = DrawTriangle3D (v1, v2, v3, color)
  let inline DrawTriangleStrip3D (points : _ []) color = DrawTriangleStrip3D (points, points.Length, color)
  let inline DrawCube position (width : float32<Width>) (height : float32<Height>) (length : float32<Length>) color = DrawCube (position, float32 width, float32 height, float32 length, color)
  let inline DrawCubeV position size color = DrawCubeV (position, size, color)
  let inline DrawCubeWires position (width : float32<Width>) (height : float32<Height>) (length : float32<Length>) color = DrawCubeWires (position, float32 width, float32 height, float32 length, color)
  let inline DrawCubeWiresV position size color = DrawCubeWiresV (position, size, color)
  let inline DrawSphere center (radius : float32<Radius>) color = DrawSphere (center, float32 radius, color)
  let inline DrawSphereEx center (radius : float32<Radius>) (rings : int<Rings>) (slices : int<Slices>) color = DrawSphereEx (center, float32 radius, int rings, int slices, color)
  let inline DrawSphereWires center (radius : float32<Radius>) (rings : int<Rings>) (slices : int<Slices>) color = DrawSphereWires (center, float32 radius, int rings, int slices, color)
  let inline DrawCylinder position (top : float32<Top>) (bottom : float32<Bottom>) (height : float32<Height>) (slices : int<Slices>) color = DrawCylinder (position, float32 top, float32 bottom, float32 height, int slices, color)
  let inline DrawCylinderEx start endPos (startRadius : float32<Radius>) (endRadius : float32<Radius>) (slices : int<Slices>) color = DrawCylinderEx (start, endPos, float32 startRadius, float32 endRadius, int slices, color)
  let inline DrawCylinderWires position (top : float32<Top>) (bottom : float32<Bottom>) (height : float32<Height>) (slices : int<Slices>) color = DrawCylinderWires (position, float32 top, float32 bottom, float32 height, int slices, color)
  let inline DrawCylinderWiresEx start endPos (startRadius : float32<Radius>) (endRadius : float32<Radius>) (slices : int<Slices>) color = DrawCylinderWiresEx (start, endPos, float32 startRadius, float32 endRadius, int slices, color)
  let inline DrawCapsule start endPos (radius : float32<Radius>) (slices : int<Slices>) (rings : int<Rings>) color = DrawCapsule (start, endPos, float32 radius, int slices, int rings, color)
  let inline DrawCapsuleWires start endPos (radius : float32<Radius>) (slices : int<Slices>) (rings : int<Rings>) color = DrawCapsuleWires (start, endPos, float32 radius, int slices, int rings, color)
  let inline DrawPlane center size color = DrawPlane (center, size, color)
  let inline DrawRay ray color = DrawRay (ray, color)
  let inline DrawGrid (slices : int<Slices>) (spacing : float32<Spacing>) = DrawGrid (int slices, float32 spacing)
  
  let inline LoadModel (fileName : string) = LoadModel fileName
  let inline LoadModelFromMesh mesh = LoadModelFromMesh mesh
  let inline IsModelReady model : bool = IsModelReady model |> CBool.op_Implicit
  let inline UnloadModel model = UnloadModel model
  let inline GetModelBoundingBox model = GetModelBoundingBox model
  
  let inline DrawModel model position (scale : float32<Scale>) color = DrawModel (model, position, float32 scale, color)
  let inline DrawModelEx model position rotation (origin : float32<Origin>) scale color = DrawModelEx (model, position, rotation, float32 origin, scale, color)
  let inline DrawModelWires model position (scale : float32<Scale>) color = DrawModelWires (model, position, float32 scale, color)
  let inline DrawModelWiresEx model position rotation (origin : float32<Origin>) scale color = DrawModelWiresEx (model, position, rotation, float32 origin, scale, color)
  let inline DrawBoundingBox box color = DrawBoundingBox (box, color)
  let inline DrawBillboard camera texture center (size : float32<BillboadSize>) color = DrawBillboard (camera, texture, center, float32 size, color)
  let inline DrawBillboardRec camera texture source center size color = DrawBillboardRec (camera, texture, source, center, size, color)
  let inline DrawBillboardPro camera texture source position up size origin (rotation : float32<Rotation>) tint = DrawBillboardPro (camera, texture, source, position, up, size, origin, float32 rotation, tint)
  
  let inline UploadMesh mesh (dynamic : bool) = UploadMesh (ref mesh, dynamic)
  let inline UpdateMeshBuffer mesh (index : int<MeshIdx>) data (dataSize : int<MeshSize>) (offset : int<MeshOffset>) = UpdateMeshBuffer (mesh, int index, data, int dataSize, int offset)
  let inline UnloadMesh mesh = UnloadMesh (ref mesh)
  let inline DrawMesh mesh material transform = DrawMesh (mesh, material, transform)
  let inline DrawMeshInstanced mesh material (transforms : _ []) = DrawMeshInstanced (mesh, material, transforms, transforms.Length)
  let inline ExportMesh mesh (fileName : string) : bool = ExportMesh (mesh, fileName) |> CBool.op_Implicit
  let inline GetMeshBoundingBox mesh = GetMeshBoundingBox mesh
  //let inline GetMeshTangents mesh = GetMeshTangents mesh
  
  let inline GenMeshPoly (sides : int<Sides>) (radius : float32<Radius>) = GenMeshPoly (int sides, float32 radius)
  let inline GenMeshPlane (width : float32<Width>) (height : float32<Height>) (x : int<X>) (z : int<Z>) = GenMeshPlane (float32 width, float32 height, int x, int z)
  let inline GenMeshCube (width : float32<Width>) (height : float32<Height>) (length : float32<Length>) = GenMeshCube (float32 width, float32 height, float32 length)
  let inline GenMeshSphere (radius : float32<Radius>) (rings : int<Rings>) (slices : int<Slices>) = GenMeshSphere (float32 radius, int rings, int slices)
  let inline GenMeshHemiSphere (radius : float32<Radius>) (rings : int<Rings>) (slices : int<Slices>) = GenMeshHemiSphere (float32 radius, int rings, int slices)
  let inline GenMeshCylinder (radius : float32<Radius>) (height : float32<Height>) (slices : int<Slices>) = GenMeshCylinder (float32 radius, float32 height, int slices)
  let inline GenMeshCone (radius : float32<Radius>) (height : float32<Height>) (slices : int<Slices>) = GenMeshCone (float32 radius, float32 height, int slices)

  let inline GenMeshTorus (radius : float32<Radius>) (size : float32<Size>) (radSegs : int<RadialSegments>) (sides : int<Sides>) = GenMeshTorus (float32 radius, float32 size, int radSegs, int sides)
  let inline GenMeshKnot (radius : float32<Radius>) (size : float32<Size>) (radSegs : int<RadialSegments>) (sides : int<Sides>) = GenMeshKnot (float32 radius, float32 size, int radSegs, int sides)
  let inline GenMeshHeightmap heightmap size = GenMeshHeightmap (heightmap, size)
  let inline GenMeshCubicmap cubicmap size = GenMeshCubicmap (cubicmap, size)
  
  //let inline LoadMaterials (fileName : string) count = LoadMaterials (fileName, count)
  let inline LoadMaterialDefault () = LoadMaterialDefault ()
  let inline IsMaterialReady material : bool = IsMaterialReady material |> CBool.op_Implicit
  let inline UnloadMaterial material = UnloadMaterial material
  let inline SetMaterialTexture material mapType texture = SetMaterialTexture (ref material, mapType, texture)
  let inline SetModelMeshMaterial model (mesh : int<MeshIdx>) (material : int<MaterialIdx>) = SetModelMeshMaterial (ref model, int mesh, int material)
  
  let inline LoadModelAnimations (fileName : string) count = LoadModelAnimations (fileName, ref count) // TODO: count to return array of animations
  let inline UpdateModelAnimation model anim (frame : int<FrameIdx>) = UpdateModelAnimation (model, anim, int frame)
  let inline UnloadModelAnimation anim = UnloadModelAnimation anim
  //let inline UnloadModelAnimations (anims : _ []) = UnloadModelAnimations (anims, uint32 anims.Length)
  let inline IsModelAnimationValid model anim : bool = IsModelAnimationValid (model, anim) |> CBool.op_Implicit
  
  let inline CheckCollisionSpheres center1 (radius1 : float32<Radius>) center2 (radius2 : float32<Radius>) : bool = CheckCollisionSpheres (center1, float32 radius1, center2, float32 radius2) |> CBool.op_Implicit
  let inline CheckCollisionBoxes box1 box2 : bool = CheckCollisionBoxes (box1, box2) |> CBool.op_Implicit
  let inline CheckCollisionBoxSphere box center (radius : float32<Radius>) : bool = CheckCollisionBoxSphere (box, center, float32 radius) |> CBool.op_Implicit
  let inline GetRayCollisionSphere ray center (radius : float32<Radius>) = GetRayCollisionSphere (ray, center, float32 radius)
  let inline GetRayCollisionBox ray box = GetRayCollisionBox (ray, box)
  let inline GetRayCollisionMesh ray mesh transform = GetRayCollisionMesh (ray, mesh, transform)
  let inline GetRayCollisionTriangle ray p1 p2 p3 = GetRayCollisionTriangle (ray, p1, p2, p3)
  let inline GetRayCollisionQuad ray p1 p2 p3 p4 = GetRayCollisionQuad (ray, p1, p2, p3, p4)
  
  
module Audio =
  open Raylib_cs
  open type Raylib_cs.Raylib

  let inline InitAudioDevice () = InitAudioDevice ()
  let inline CloseAudioDevice () = CloseAudioDevice ()
  let inline IsAudioDeviceReady () : bool = IsAudioDeviceReady () |> CBool.op_Implicit
  let inline SetMasterVolume volume = SetMasterVolume volume
  let inline GetMasterVolume () = GetMasterVolume ()
  
  let inline LoadWave (fileName : string) = LoadWave fileName
  //let inline LoadWaveFromMemory (fileType : string) (fileData : byte []) dataSize = LoadWaveFromMemory (fileType, fileData, dataSize)
  let inline IsWaveReady wave : bool = IsWaveReady wave |> CBool.op_Implicit
  let inline LoadSound (fileName : string) = LoadSound fileName
  let inline LoadSoundFromWave wave = LoadSoundFromWave wave
  let inline LoadSoundAlias source = LoadSoundAlias source
  let inline IsSoundReady sound : bool = IsSoundReady sound |> CBool.op_Implicit
  let inline UpdateSound sound data (samplesCount : int<SamplesCount>) = UpdateSound (sound, data, int samplesCount)
  let inline UnloadWave wave = UnloadWave wave
  let inline UnloadSound sound = UnloadSound sound
  let inline UnloadSoundAlias sound = UnloadSoundAlias sound
  let inline ExportWave wave (fileName : string) : bool = ExportWave (wave, fileName) |> CBool.op_Implicit
  let inline ExportWaveAsCode wave (fileName : string) : bool = ExportWaveAsCode (wave, fileName) |> CBool.op_Implicit
  
  let inline PlaySound sound = PlaySound sound
  let inline StopSound sound = StopSound sound
  let inline PauseSound sound = PauseSound sound
  let inline ResumeSound sound = ResumeSound sound
  let inline IsSoundPlaying sound : bool = IsSoundPlaying sound |> CBool.op_Implicit
  let inline SetSoundVolume sound (volume : float32<Volume>) = SetSoundVolume (sound, float32 volume)
  let inline SetSoundPitch sound (pitch : float32<Pitch>) = SetSoundPitch (sound, float32 pitch)
  let inline SetSoundPan sound (pan : float32<Pan>) = SetSoundPan (sound, float32 pan)
  let inline WaveCopy wave = WaveCopy wave
  let inline WaveCrop wave (initSample : int<InitSample>) (finalSample : int<FinalSample>) = WaveCrop (ref wave, int initSample, int finalSample)
  let inline WaveFormat wave (sampleRate : int<SampleRate>) (sampleSize : int<SampleSize>) (channels : int<Channels>) = WaveFormat (ref wave, int sampleRate, int sampleSize, int channels)
  let inline LoadWaveSamples wave = LoadWaveSamples wave
  let inline UnloadWaveSamples samples = UnloadWaveSamples samples
  
  let inline LoadMusicStream (fileName : string) = LoadMusicStream fileName
  //let inline LoadMusicStreamFromMemory (fileType : string) (fileData : byte []) dataSize = LoadMusicStreamFromMemory (fileType, fileData, dataSize)
  let inline IsMusicReady music : bool = IsMusicReady music |> CBool.op_Implicit
  let inline UnloadMusicStream music = UnloadMusicStream music
  let inline PlayMusicStream music = PlayMusicStream music
  let inline IsMusicStreamPlaying music : bool = IsMusicStreamPlaying music |> CBool.op_Implicit
  let inline UpdateMusicStream music = UpdateMusicStream music
  let inline StopMusicStream music = StopMusicStream music
  let inline PauseMusicStream music = PauseMusicStream music
  let inline ResumeMusicStream music = ResumeMusicStream music
  let inline SeekMusicStream music (time : float32<SeekTime>) = SeekMusicStream (music, float32 time)
  let inline SetMusicVolume music (volume : float32<Volume>) = SetMusicVolume (music, float32 volume)
  let inline SetMusicPitch music (pitch : float32<Pitch>) = SetMusicPitch (music, float32 pitch)
  let inline SetMusicPan music (pan : float32<Pan>) = SetMusicPan (music, float32 pan)
  let inline GetMusicTimeLength music = GetMusicTimeLength music |> LanguagePrimitives.Float32WithMeasure<MusicLength>
  let inline GetMusicTimePlayed music = GetMusicTimePlayed music |> LanguagePrimitives.Float32WithMeasure<SeekTime>
  
  let inline LoadAudioStream (sampleRate : uint32<SampleRate>) (sampleSize : uint32<SampleSize>) (channels : uint32<Channels>) = LoadAudioStream (uint32 sampleRate, uint32 sampleSize, uint32 channels)
  let inline IsAudioStreamReady stream : bool = IsAudioStreamReady stream |> CBool.op_Implicit
  let inline UnloadAudioStream stream = UnloadAudioStream stream
  let inline UpdateAudioStream stream data (samplesCount : int<SamplesCount>) = UpdateAudioStream (stream, data, int samplesCount)
  let inline IsAudioStreamProcessed stream : bool = IsAudioStreamProcessed stream |> CBool.op_Implicit
  let inline PlayAudioStream stream = PlayAudioStream stream
  let inline PauseAudioStream stream = PauseAudioStream stream
  let inline ResumeAudioStream stream = ResumeAudioStream stream
  let inline IsAudioStreamPlaying stream : bool = IsAudioStreamPlaying stream |> CBool.op_Implicit
  let inline StopAudioStream stream = StopAudioStream stream
  let inline SetAudioStreamVolume stream (volume : float32<Volume>) = SetAudioStreamVolume (stream, float32 volume)
  let inline SetAudioStreamPitch stream (pitch : float32<Pitch>) = SetAudioStreamPitch (stream, float32 pitch)
  let inline SetAudioStreamPan stream (pan : float32<Pan>) = SetAudioStreamPan (stream, float32 pan)
  let inline SetAudioStreamBufferSizeDefault (size : int<BufferSize>) = SetAudioStreamBufferSizeDefault (int size)
  let inline SetAudioStreamCallback stream callback = SetAudioStreamCallback (stream, callback)
  
  let inline AttachAudioStreamProcessor stream proc = AttachAudioStreamProcessor (stream, proc)
  let inline DetachAudioStreamProcessor stream proc = DetachAudioStreamProcessor (stream, proc)
  
  let inline AttachAudioMixedProcessor proc = AttachAudioMixedProcessor proc
  let inline DetachAudioMixedProcessor proc = DetachAudioMixedProcessor proc
  
module Math =
  open type Raylib_cs.Raymath
  
  let inline Clamp value min max = Clamp (value, min, max)
  let inline Lerp start end_ amount = Lerp (start, end_, amount)
  let inline Normalize value start end_ = Normalize (value, start, end_)
  let inline Remap value inputStart inputEnd outputStart outputEnd = Remap (value, inputStart, inputEnd, outputStart, outputEnd)
  let inline Wrap value min max = Wrap (value, min, max)
  let inline FloatEquals a b = FloatEquals (a, b) > 0
  
  let inline Vector2Zero () = Vector2Zero ()
  let inline Vector2One () = Vector2One ()
  let inline Vector2Add v1 v2 = Vector2Add (v1, v2)
  let inline Vector2AddValue v1 add = Vector2AddValue (v1, add)
  let inline Vector2Subtract v1 v2 = Vector2Subtract (v1, v2)
  let inline Vector2SubtractValue v1 sub = Vector2SubtractValue (v1, sub)
  let inline Vector2Length v = Vector2Length v |> LanguagePrimitives.Float32WithMeasure<Length>
  let inline Vector2LengthSqr v = Vector2LengthSqr v |> LanguagePrimitives.Float32WithMeasure<Length ^ 2>
  let inline Vector2DotProduct v1 v2 = Vector2DotProduct (v1, v2)
  let inline Vector2Distance v1 v2 = Vector2Distance (v1, v2) |> LanguagePrimitives.Float32WithMeasure<Distance>
  let inline Vector2DistanceSqr v1 v2 = Vector2DistanceSqr (v1, v2) |> LanguagePrimitives.Float32WithMeasure<Distance ^ 2>
  let inline Vector2Angle v1 v2 = Vector2Angle (v1, v2) |> LanguagePrimitives.Float32WithMeasure<Angle>
  let inline Vector2Scale v scale = Vector2Scale (v, scale)
  let inline Vector2Multiply v1 v2 = Vector2Multiply (v1, v2)
  let inline Vector2Negate v = Vector2Negate v
  let inline Vector2Divide v1 v2 = Vector2Divide (v1, v2)
  let inline Vector2Normalize v = Vector2Normalize v
  let inline Vector2Transform v mat = Vector2Transform (v, mat)
  let inline Vector2Lerp v1 v2 amount = Vector2Lerp (v1, v2, amount)
  let inline Vector2Reflect v normal = Vector2Reflect (v, normal)
  let inline Vector2Rotate v degs = Vector2Rotate (v, degs)
  let inline Vector2MoveTowards current target maxDistance = Vector2MoveTowards (current, target, maxDistance)
  let inline Vector2Invert v = Vector2Invert v
  let inline Vector2Clamp v min max = Vector2Clamp (v, min, max)
  let inline Vector2ClampValue v min max = Vector2ClampValue (v, min, max)
  let inline Vector2Equals v1 v2 = Vector2Equals (v1, v2) > 0
  
  let inline Vector3Zero () = Vector3Zero ()
  let inline Vector3One () = Vector3One ()
  let inline Vector3Add v1 v2 = Vector3Add (v1, v2)
  let inline Vector3AddValue v1 add = Vector3AddValue (v1, add)
  let inline Vector3Subtract v1 v2 = Vector3Subtract (v1, v2)
  let inline Vector3SubtractValue v1 sub = Vector3SubtractValue (v1, sub)
  let inline Vector3Scale v scale = Vector3Scale (v, scale)
  let inline Vector3Multiply v1 v2 = Vector3Multiply (v1, v2)
  let inline Vector3CrossProduct v1 v2 = Vector3CrossProduct (v1, v2)
  let inline Vector3Perpendicular v = Vector3Perpendicular v
  let inline Vector3Length v = Vector3Length v |> LanguagePrimitives.Float32WithMeasure<Length>
  let inline Vector3LengthSqr v = Vector3LengthSqr v |> LanguagePrimitives.Float32WithMeasure<Length ^ 2>
  let inline Vector3DotProduct v1 v2 = Vector3DotProduct (v1, v2)
  let inline Vector3Distance v1 v2 = Vector3Distance (v1, v2) |> LanguagePrimitives.Float32WithMeasure<Distance>
  let inline Vector3DistanceSqr v1 v2 = Vector3DistanceSqr (v1, v2) |> LanguagePrimitives.Float32WithMeasure<Distance ^ 2>
  let inline Vector3Angle v1 v2 = Vector3Angle (v1, v2)
  let inline Vector3Negate v = Vector3Negate v
  let inline Vector3Divide v1 v2 = Vector3Divide (v1, v2)
  let inline Vector3Normalize v = Vector3Normalize v
  let inline Vector3OrthoNormalize v1 v2 = Vector3OrthoNormalize (v1, v2)
  let inline Vector3Transform v mat = Vector3Transform (v, mat)
  let inline Vector3RotateByQuaternion v q = Vector3RotateByQuaternion (v, q)
  let inline Vector3RotateByAxisAngle v axis (angle : float32<Angle>) = Vector3RotateByAxisAngle (v, axis, float32 angle)
  let inline Vector3Lerp v1 v2 amount = Vector3Lerp (v1, v2, amount)
  let inline Vector3Reflect v normal = Vector3Reflect (v, normal)
  let inline Vector3Min v1 v2 = Vector3Min (v1, v2)
  let inline Vector3Max v1 v2 = Vector3Max (v1, v2)
  let inline Vector3Barycenter p a b c = Vector3Barycenter (p, a, b, c)
  let inline Vector3Unproject source projection view = Vector3Unproject (source, projection, view)
  let inline Vector3ToFloatV v = Vector3ToFloatV v
  let inline Vector3Invert v = Vector3Invert v
  let inline Vector3Clamp v min max = Vector3Clamp (v, min, max)
  let inline Vector3ClampValue v min max = Vector3ClampValue (v, min, max)
  let inline Vector3Equals v1 v2 = Vector3Equals (v1, v2) > 0
  let inline Vector3Refract v n r = Vector3Refract (v, n, r)
  
  let inline MatrixDeterminant mat = MatrixDeterminant mat |> LanguagePrimitives.Float32WithMeasure<Determinant>
  let inline MatrixTrace mat = MatrixTrace mat |> LanguagePrimitives.Float32WithMeasure<Trace>
  let inline MatrixTranspose mat = MatrixTranspose mat
  let inline MatrixInvert mat = MatrixInvert mat
  let inline MaxtrixIdentity () = Matrix4x4.Identity
  let inline MatrixAdd m1 m2 = MatrixAdd (m1, m2)
  let inline MatrixSubtract m1 m2 = MatrixSubtract (m1, m2)
  let inline MatrixMultiply m1 m2 = MatrixMultiply (m1, m2)
  let inline MatrixTranslate (x : float32<X>) (y : float32<Y>) (z : float32<Z>) = MatrixTranslate (float32 x, float32 y, float32 z)
  let inline MatrixRotate axis (angle : float32<Angle>) = MatrixRotate (axis, float32 angle)
  let inline MatrixRotateX (angle : float32<Angle>) = MatrixRotateX (float32 angle)
  let inline MatrixRotateY (angle : float32<Angle>) = MatrixRotateY (float32 angle)
  let inline MatrixRotateZ (angle : float32<Angle>) = MatrixRotateZ (float32 angle)
  let inline MatrixRotateXYZ (ang : Vector3) = MatrixRotateXYZ ang
  let inline MatrixRotateZYX (ang : Vector3) = MatrixRotateZYX ang
  let inline MatrixScale (x : float32<X>) (y : float32<Y>) (z : float32<Z>) = MatrixScale (float32 x, float32 y, float32 z)
  let inline MatrixFrustum left right bottom top near far = MatrixFrustum (left, right, bottom, top, near, far)
  let inline MatrixPerspective fovy aspect near far = MatrixPerspective (fovy, aspect, near, far)
  let inline MatrixOrtho left right bottom top near far = MatrixOrtho (left, right, bottom, top, near, far)
  let inline MatrixLookAt eye target up = MatrixLookAt (eye, target, up)
  let inline MatrixToFloatV mat = MatrixToFloatV mat
  
  let inline QuaternionAdd q1 q2 = QuaternionAdd (q1, q2)
  let inline QuaternionAddValue q add = QuaternionAddValue (q, add)
  let inline QuaternionSubtract q1 q2 = QuaternionSubtract (q1, q2)
  let inline QuaternionSubtractValue q sub = QuaternionSubtractValue (q, sub)
  let inline QuaternionIdentity () = QuaternionIdentity ()
  let inline QuaternionLength q = QuaternionLength q |> LanguagePrimitives.Float32WithMeasure<Length>
  let inline QuaternionNormalize q = QuaternionNormalize q
  let inline QuaternionInvert q = QuaternionInvert q
  let inline QuaternionMultiply q1 q2 = QuaternionMultiply (q1, q2)
  let inline QuaternionScale q (scale : float32<Scale>) = QuaternionScale (q, float32 scale)
  let inline QuaternionDivide q1 q2 = QuaternionDivide (q1, q2)
  let inline QuaternionLerp q1 q2 amount = QuaternionLerp (q1, q2, amount)
  let inline QuaternionNlerp q1 q2 amount = QuaternionNlerp (q1, q2, amount)
  let inline QuaternionSlerp q1 q2 amount = QuaternionSlerp (q1, q2, amount)
  let inline QuaternionFromVector3ToVector3 from to_ = QuaternionFromVector3ToVector3 (from, to_)
  let inline QuaternionFromMatrix mat = QuaternionFromMatrix mat
  let inline QuaternionFromAxisAngle axis (angle : float32<Angle>) = QuaternionFromAxisAngle (axis, float32 angle)
  let inline QuaternionToAxisAngle q outAxis outAngle = QuaternionToAxisAngle (q, outAxis, outAngle)
  let inline QuaternionFromEuler (pitch : float32<PitchEuler>) (yaw : float32<Yaw>) (roll : float32<Roll>) = QuaternionFromEuler (float32 pitch, float32 yaw, float32 roll)
  let inline QuaternionToEuler q = QuaternionToEuler q
  let inline QuaternionTransform q mat = QuaternionTransform (q, mat)
  let inline QuaternionEquals q1 q2 = QuaternionEquals (q1, q2) > 0
