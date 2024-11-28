public class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество одномерных массивов: ");
        int n = int.Parse(Console.ReadLine());
        int[][] mas = new int[n][];
        
        for (int i = 1; i < n + 1; i++)
        {
            Console.WriteLine($"Введите количество элементов в {i} массиве");
            int p = int.Parse(Console.ReadLine());
            int[] mas2 = new int[p];
            int max = int.MinValue, min = int.MaxValue;
            Console.WriteLine("Введите элементы:");
            for (int j = 0; j < p; j++)
            {
                mas2[j] = int.Parse(Console.ReadLine());

            }
            for (int j = 0; j < p; j++)
            {
                if (mas2[j] > max)
                {
                    max = mas2[j];
                }
                if (mas2[j] < min)
                {
                    min = mas2[j];
                }
            }
            Console.WriteLine("Максимальный элемент в строке: " + max);
            Console.WriteLine("Минимальный элемент в строке: " + min);
        }
        
    }
}
