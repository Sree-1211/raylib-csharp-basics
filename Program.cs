using Raylib_cs;

namespace TestProject_;
class Program
{
    private static float pos=10;
    public static void Main()
    {
        Raylib.InitWindow(500, 500, "test window");
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Draw();
            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }
    private static void Draw()
    {
        pos+=0.01f;
        Raylib.DrawText("Hello", 10, (int)pos, 20, Color.White);
        Raylib.ClearBackground(Color.DarkGray);
    }
}
