namespace Dz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } };
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " "); 
                }
                Console.WriteLine(); 
            }
            Console.WriteLine();
            int col1 = int.Parse(Console.ReadLine()), col2 = int.Parse(Console.ReadLine()); ;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int b = a[i, col1-1];
                a[i, col1-1] = a[i, col2-1];
                a[i, col2-1] = b;
            }
            Console.WriteLine();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
