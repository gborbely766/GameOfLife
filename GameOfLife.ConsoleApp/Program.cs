namespace GameOfLife.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var world = new World(10, 30);
            world.PrintWorld();
        }
    }
}
