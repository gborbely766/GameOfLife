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
                    world[i, j] = new Cell(i, j);
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
                for(int j = 0; j < world.GetLength(1) ; j++)
                {
                    Console.Write(world[i, j].ToString());
                    if (j == world.GetLength(1) - 2) Console.WriteLine("\r");
                }
                
            }
            Console.SetCursorPosition(0, Console.WindowTop);
        }
        private int GetNeighbors(int x, int y)
        {
            int numberOfNeighbors = 0;
            for (int i = x - 1; i < x + 2; i++)
            {
                for (int j = y- 1; j < y + 2; j++)
                {
                    if (!((i < 0 || j < 0) || (i >= world!.GetLength(0) || j >= world!.GetLength(1))))
                    {
                    
                            if (world[i, j].IsAlive == true)
                            {
                                numberOfNeighbors++;
                            }
                            
                    
                        
                    }
                }
                
            }
            return numberOfNeighbors;
        }
        private void Grow()
        {
            
            for (int i = 0; i < world!.GetLength(0); i++)
            {
                for (int j = 0; j < world!.GetLength(1); j++)
                {
                    int neighbors = GetNeighbors(i, j);
                    
                    if (world[i,j].IsAlive)
                    {
                        
                        if (neighbors < 2)
                        {
                            world[i,j].IsAlive = false;
                        }

                        if (neighbors > 3)
                        {
                            world[i,j].IsAlive = false;
                        }
                    }
                    else
                    {
                        if (neighbors == 3)
                        {
                            world[i,j].IsAlive = true;
                        }
                        else
                        {
                            world[i, j].IsAlive = false;
                        }
                    }
                }
            }
        }
        
    }
}
