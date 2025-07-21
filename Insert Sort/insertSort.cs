using System;

class Program
{
    static void Main()
    {
        InsertSort insertSortInstance = new InsertSort();

        int[] disorderedElements = new int[] { 5, 4, 2, 3, 1, 42, 99, 54, 76, 78, 35, 64, 5, 4, 23, 6, 76, 45, 24, 32, 77, 54, 56, 6 };

        int[] ascendingElements = insertSortInstance.Ascending(disorderedElements);

        Console.WriteLine("Elementos ordenados de forma crescente");
        Console.WriteLine(string.Join(", ", ascendingElements));
    }
}

class InsertSort
{
    public int[] Ascending(int[] elements)
    {
        int[] ordenedElements = (int[])elements.Clone();

        for (int j = 1; j < ordenedElements.Length; j++)
        {
            int key = ordenedElements[j];
            int i = j - 1;

            while (i >= 0 && ordenedElements[i] > key)
            {
                ordenedElements[i + 1] = ordenedElements[i];
                i--;
            }

            ordenedElements[i + 1] = key;
        }

        return ordenedElements;
    }
}