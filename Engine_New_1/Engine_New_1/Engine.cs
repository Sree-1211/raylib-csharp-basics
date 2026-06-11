using Raylib_cs;

namespace Prathyaksh
{
    
    internal class Engine
    {
        private int width;
        private int height;

        private string tittle;
        public Engine(int width,int height,string tittle)
        {
            // Initialize the engine
            this.width = width;
            this.height = height;
            this.tittle = tittle;

            Raylib.InitWindow(width, height, tittle);

        }
        public void Run()
        {
           while(!Raylib.WindowShouldClose())
           {
               Input();
               Update();
               Render();
           }
            CloseUp();
        }

        private void CloseUp()
        {
            Raylib.CloseWindow();
        }

        private void Input()
        {
            
        }

        private void Update()
        {

        }

        private void Render()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.DarkGray);
            Raylib.EndDrawing();
        }
    }
}
