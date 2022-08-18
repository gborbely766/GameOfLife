namespace GameOfLife.ConsoleApp
{
    public class Program
    {
        private const int maxRun = 100;
        public static void Main(string[] args)
        {
            var world = new World(10, 30);
            int runs = 0;
            while (runs++ < maxRun)
            {
                world.DrowAndGrow();
                Thread.Sleep(100);
                
                
            }
        }
    }
}
