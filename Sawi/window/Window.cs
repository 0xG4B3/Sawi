using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace Sawi.window;

public class Window : NativeWindow
{
    public Window(NativeWindowSettings settings) : base(settings)
    {
        this.Context.MakeCurrent();
    }
    
    public void OnUpdate()
    {
        
    }
}