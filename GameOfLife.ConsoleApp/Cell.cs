using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.ConsoleApp
{
    public class Cell
    {
        public int X { get; }
        public int Y { get; }
        public bool IsAlive { get; set; }
        
        public Cell(int x, int y)
        {
            X = x;
            Y = y;
            IsAlive = RandomBool();
        }
        private bool RandomBool() 
        {
            int randInt = new Random().Next(2); ;
            return randInt == 0 ? false : true;
        }
        public override string ToString()
        {
            return (this.IsAlive == false ? " " : "#");
        }
        
    }
}
