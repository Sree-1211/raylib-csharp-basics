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
           

        }
    }
}
