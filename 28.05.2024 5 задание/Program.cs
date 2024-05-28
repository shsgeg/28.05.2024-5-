using System;
class Program
{
    static void Main()
    {
        int[] array1 = { 1, 2, 3, 3 };
        int[] array2 = { 4, 5, 6, 4 };
        string[] array3 = { "a", "aa", "bb", "cd" };
        string[] array4 = { "dd", "ee", "r", "cc" };

        int[] mergedArray = MergeArrays(array1, array2);
        string[] mergedArray1 = MergeArrays(array3, array4);

        Console.WriteLine("Слияние массивов чисел:");
        PrintArray(mergedArray);

        Console.WriteLine("Слияние массивов строк:");
        PrintArray(mergedArray1);
    }

    static T[] MergeArrays<T>(T[] array1, T[] array2)
    {
        T[] mergedArray = new T[array1.Length + array2.Length];

        Array.Copy(array1, mergedArray, array1.Length);
        Array.Copy(array2, 0, mergedArray, array1.Length, array2.Length);

        return mergedArray;
    }
    static void PrintArray<T>(T[] array)
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}