// See https://aka.ms/new-console-template for more information
internal class Program
{
    static void Main()
    {

        Console.WriteLine("Завдання 1");

        int[,] two_dimensional = {
            {1, 2, 9},
            {7, 7, 6},
            {7, 5, 9}
        };
        int suma = 0;
        for (int i = 0; i < two_dimensional.GetLength(0); i++)
        {
            suma += two_dimensional[i,i];

        }
        Console.WriteLine("Сума елементів по головній діагоналі" + suma);

        Console.WriteLine("Завдання 2");

        int[,] massif = {
            {5, 5, 4},
            {4, 8, 6},
            {3, 8, 9}
        };


        Console.Write("matrixColumn = ");
        int matrixColumn = Convert.ToInt32(Console.ReadLine());
        int columnProduct = CalculateColumnProduct(massif, matrixColumn - 1);
       

        if (columnProduct != -1)
        {
            Console.WriteLine("Добуток елементiв стовпця " + matrixColumn + ": " + columnProduct);
        }
        else
        {
            Console.WriteLine("Не існує такого номера стовпця.");
        }

       static int CalculateColumnProduct(int[,] massif, int columnIndex)
        {
            if (columnIndex < 0 || columnIndex >= massif.GetLength(1))
            {
                return -1;
            }

            int product = 1;
            for (int i = 0; i < massif.GetLength(0); i++)
            {
                product *= massif[i, columnIndex];
            }
            return product;
        }

    }
}