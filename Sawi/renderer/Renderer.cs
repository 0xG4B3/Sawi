using OpenTK.Graphics.OpenGL4;
using Sawi.window;

namespace Sawi.renderer;

public static class Renderer
{
    private static Window _window;
    static public void InitRenderer(Window window)
    {
        _window = window;
        GL.Viewport(0, 0, window.Size.X, window.Size.Y);    
    }

    static public void OnUpdate()
    {
        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
        GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
        _window.Context.SwapBuffers();
    }
}