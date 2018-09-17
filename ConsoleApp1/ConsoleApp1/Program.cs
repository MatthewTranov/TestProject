using System;

namespace ConsoleApp1
{
    class Program
    {
        public bool running = true;
        public bool[,] grid = new bool[24, 10];
        

        public void display()
        {
            for(int i=0; i < grid.GetLength(0); i++)
            {
                for(int j=0; j < grid.GetLength(1);j++)
                {
                    if (grid[i,j])
                        Console.Write("o");
                    else
                        Console.Write("x");
                }
                Console.WriteLine("");
            }
        }

        static void Main(string[] args)
        {
            Program game = new Program();
            game.grid[1, 1] = true;
            Console.Clear();
            game.display();
            Console.ReadKey();
        }

    }
}
