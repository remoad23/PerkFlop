using Silk.NET.Maths;
using Silk.NET.Windowing;


WindowOptions options = WindowOptions.Default with
{
    Size = new Vector2D<int>(800, 600),
    Title = "My first Silk.NET application!"
};

IWindow _window;

_window = Window.Create(options);

_window.Run();