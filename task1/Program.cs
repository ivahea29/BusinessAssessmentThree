using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

class Program
{
static void Main()
    {
        ReadFile();
        int[] arr = GenerateUniqueRandomNumbers(5);
        ArrayOperations(arr);
    }
    static int[] GenerateUniqueRandomNumbers(int size)
    {
        Random random = new Random();//inferred data type
        var values = new HashSet<int>();
        while(true)
        {
            values.Add(random.Next(1, 100));
            if(values.Count == size) break;
        }
        return values.ToArray();
    }
static void ArrayOperations(int[] arr)
    {
        arr.ToList().ForEach(WriteLine);
        int m = arr.Min();
        // WriteLine(m);
        //string interpolation
        WriteLine($"Min value in array: {m, 5}");

        int idx = Array.IndexOf(arr, m);
        WriteLine($"Index: {idx}");

        int Min = int.MinValue;
        foreach(int i in arr)
        {
            if(i > Min) Min = i;
        }
        WriteLine(Min);
    }
static void ReadFile()
    {
        string[] lines = null;
        try
        {
            lines = File.ReadAllLines("data.txt");
        }
        catch (IOException e)
        {
            WriteLine(e.Source);
        }
        if (lines != null)
        {
            int[] numArr = Array.ConvertAll(lines, int.Parse);
            numArr.ToList().ForEach(WriteLine);
            foreach(int i in numArr)
            {
                Write(i + " ");
            }
        }
        WriteLine("The numbers in the file are: " + lines);
    }
}