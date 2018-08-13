using System;
using System.Threading.Tasks;
using BlazorClockCanvasComponent.Classes;
using Microsoft.JSInterop;

namespace BlazorClockCanvasComponent
{
    public static class JsInterop
    {
        public static string Prompt(string message)
        {
            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<string>(
                "JsInteropClockCanvas.Prompt",
                message);
        }


        public static bool Alert(string message)
        {
            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>(
                "JsInteropClockCanvas.Alert",
                message);
        }


        public static bool Log_Canvas_Array()
        {
            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>(
                "JsInteropClockCanvas.Log_Canvas_Array");
        }

        public static bool Render_To_UI(string canvasID)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Render_To_UI", canvasID);
        }

        

        public static bool Draw_Circle(string canvasID, TransferParameters transferParameters)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Draw_Circle",
                new { canvasID, transferParameters });
        }

        public static bool Stroke_Rect(string canvasID, TransferRectParameters transferRectParameters)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Stroke_Rect",
                new { canvasID, transferRectParameters });
        }


        

        public static bool Draw_Image(string canvasID, string imgName, TransferImageParameters transferImageParameters)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Draw_Image",
                new { canvasID, imgName, transferImageParameters });
        }


        public static bool Draw_Gauge(string canvasID, string color, TransferParameters transferParameters)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Draw_Gauge",
                new { canvasID, color, transferParameters });
        }

        public static bool Set_Property(string canvasID, TransferCanvasProperty transferCanvasProperty)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Set_Property",
                new { canvasID, transferCanvasProperty });
        }

        public static bool Fill_Text(string canvasID, TransferFillTextParameters transferFillTextParameters)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Fill_Text",
                new { canvasID, transferFillTextParameters });
        }

        public static bool Create_Radial_Gradient(string canvasID, TransferRadialGradientParameters transferRadialGradientParameters)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Create_Radial_Gradient",
                new { canvasID, transferRadialGradientParameters });
        }
        

        public static bool Clear_Canvas(string canvasID)
        {
            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Clear_Canvas", canvasID);
        }

  

        public static bool Save_State(string canvasID)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.CanvasSaveState", canvasID);
        }

        public static bool Restore_State(string canvasID)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.CanvasRestoreState", canvasID);
        }

        public static bool Set_Transform(string canvasID)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Set_Transform", canvasID);
        }

        public static bool Begin_Path(string canvasID)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Begin_Path", canvasID);
        }


        public static bool Stroke(string canvasID)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Stroke", canvasID);
        }

        public static bool Fill(string canvasID)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Fill", canvasID);
        }

        public static bool Draw_Full_Size_Rect(string canvasID, string color)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.draw_Full_Size_Rect", new { canvasID, color });
        }


        public static bool Translate(string canvasID, float x, float y)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Translate",
                new { canvasID, x, y });
        }

        public static bool Rotate(string canvasID, float angle)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Rotate",new { canvasID, angle });
        }



        public static bool Move_To(string canvasID, float x, float y)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Move_To",
                new {canvasID, x, y });
        }

        public static bool Line_To(string canvasID, float x, float y)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Line_To",
                new { canvasID, x, y });
        }


        public static bool Add_Canvas(string canvasID, string BgCanvasID, string TopCanvasID)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Add_Canvas",new { canvasID, BgCanvasID, TopCanvasID });


        }


        public static bool Remove_Canvas(string canvasID)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Remove_Canvas", canvasID);
        }


        public static bool DrawPieChart(string canvasID)
        {
        
                return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JavaScriptDrawPieChart", canvasID);
        }



        public static async Task<string> Preload_Image()
        {

            return await (JSRuntime.Current as IJSInProcessRuntime).InvokeAsync<string>("JsInteropClockCanvas.Preload_Image");
        }


        public static bool Gradient_Add_Color_Stop(float stop, string color)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Gradient_Add_Color_Stop",
                new { stop, color });
        }


        public static bool Gradient_Set_Stoke_Or_Fill_Style(string canvasID, bool StrokeOrFill)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Gradient_Set_Stoke_Or_Fill_Style",
                new { canvasID, StrokeOrFill });
        }

        public static bool Execute_Dynamic_Script(string cmd)
        {

            return (JSRuntime.Current as IJSInProcessRuntime).Invoke<bool>("JsInteropClockCanvas.Execute_Dynamic_Script", cmd);
        }

    }
}
