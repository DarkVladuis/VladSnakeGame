using System;

namespace SnakeGame
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            //Влад великолепный программист
            using (var game = new MainGame())
                game.Run();
        }
    }
}
