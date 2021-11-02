namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayManager manager = new ArrayManager(4, 5);
            int[,] a = manager.Create();
            int max = manager.GetMax(a);
            System.Console.WriteLine(max);
        }
    }
}
