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
        public void DrowAndGrow()
        {
            Draw();
            Grow();
            
        }
        private void Draw()
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
        private void GetNeighbors(Cell cell)
        {
            for (int i = cell.X - 1; i < cell.X + 2; i++)
            {
                for (int j = cell.Y- 1; j < cell.Y + 2; j++)
                {
                    if (!((i < 0 || j < 0) || (i >= world!.GetLength(0) || j >= world!.GetLength(1))))
                    {
                        if (i != cell.X && j != cell.Y)
                        {
                            if (world[i, j].IsAlive == true)
                            {
                                world[i, j].NumberOfNeighbors += 1;
                            }
                        }
                        
                    }
                }
                
            }
        }
        private void Grow()
        {
            for (int i = 0; i < world!.GetLength(0); i++)
            {
                for (int j = 0; j < world!.GetLength(1); j++)
                {
                    var cell = world[i, j];
                    if (cell.IsAlive)
                    {
                        GetNeighbors(cell);
                        if (cell.NumberOfNeighbors < 2)
                        {
                            cell.IsAlive = false;
                        }

                        if (cell.NumberOfNeighbors > 3)
                        {
                            cell.IsAlive = false;
                        }
                    }
                    else
                    {
                        if (cell.NumberOfNeighbors == 3)
                        {
                            cell.IsAlive = true;
                        }
                    }
                }
            }
        }
    }
}
