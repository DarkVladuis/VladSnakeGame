using System;

namespace SnakeGame
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            //тутуру
            using (var game = new MainGame())
                game.Run();
        }
    }
}
