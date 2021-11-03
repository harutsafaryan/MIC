namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayManager arrManager = new ArrayManager(); //create 4x5 matrix  
            PrinterManager printManager = new PrinterManager();
            int[,] a = arrManager.Create(7, 6);
            int[] b = arrManager.Create(8);

            printManager.Print(a);
            System.Console.WriteLine();
            arrManager.Swap(a);
            printManager.Print(a);

            int max = arrManager.GetMax(b);

            System.Console.WriteLine(max);
        }
    }
}
