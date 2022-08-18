using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.ConsoleApp
{
    public class World
    {
        public Cell[,]? world { get; set; }

        public World(int height, int width)
        {
            world = new Cell[height, width];
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    world![i, j] = new Cell(i, j);
                }
                
            }
        }
        public void PrintWorld()
        {
            for(int i = 0; i < world!.GetLength(0); i++)
            {
                for(int j = 0; j < world.GetLength(1); j++)
                {
                    Console.Write(world[i, j].ToString());
                }
                Console.WriteLine("\n");
            }
        }
    }
}
