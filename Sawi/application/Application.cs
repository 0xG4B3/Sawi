using System.Text;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using Sawi.renderer;
using Sawi.window;

namespace Sawi.application;

public class Application
{
    
    private NativeWindowSettings _settings = NativeWindowSettings.Default;
    private Window _window;
    
    public Application(string title, int width, int height)
    {
        _settings.Title = title;
        _settings.Flags = ContextFlags.ForwardCompatible;
        _settings.ClientSize = new Vector2i(width, height);
        _settings.APIVersion = new Version(4, 6);
        _settings.Vsync = VSyncMode.On;
        
        _window = new Window(_settings);
        Renderer.InitRenderer(_window);
    }

    public void Run()
    {
        while (true)
        {
            Renderer.OnUpdate();
           _window.OnUpdate();
        }
    }
}