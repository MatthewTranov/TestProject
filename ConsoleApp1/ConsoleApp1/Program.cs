using System;

namespace ConsoleApp1
{
    class Program
    {
        public bool running;
        public int width, length, x,y;
        public bool[,] grid;
        public Program()
        {
            running = true;
            width = 10;
            length = 24;
            grid = new bool[length, width];
            x = 1;
            y = 1;
        }
        

        public void display()
        {
            Console.Clear();
            for (int i=0; i < grid.GetLength(0); i++)
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

        public void getInput()
        {
            ConsoleKey key;
            do
            {
                while (!Console.KeyAvailable)
                {
                    // Do something, but don't read key here
                }
                // Key is available - read it
                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.W && x > 0)
                {
                    grid[x, y] = false;
                    x--;
                    grid[x, y] = true;
                    display();
                }
                else if (key == ConsoleKey.S && x < length-2)
                {
                    grid[x, y] = false;
                    x++;
                    grid[x, y] = true;
                    display();
                }
                else if (key == ConsoleKey.A && y > 0)
                {
                    grid[x, y] = false;
                    y--;
                    grid[x, y] = true;
                    display();
                }
                else if (key == ConsoleKey.D && y < width - 2)
                {
                    grid[x, y] = false;
                    y++;
                    grid[x, y] = true;
                    display();
                }
                
            } while (key != ConsoleKey.Escape);
        }

        static void Main(string[] args)
        {
            Program game = new Program();
            
            game.getInput();
            Console.ReadKey();
        }

    }
}
