using System;
using System.Collections.Generic;
using System.Diagnostics;
public class GenericAdder
{
    public T Add<T>(T a, T b)
    {
        if (typeof(T) == typeof(int) || typeof(T) == typeof(double) || typeof(T) == typeof(float))
        {
            return (dynamic)a + (dynamic)b;
        }
        else if (typeof(T) == typeof(string))
        {
            return (dynamic)a + (dynamic)b;
        }
        else if (typeof(T).IsArray)
        {
            Array arrayA = (Array)(object)a;
            Array arrayB = (Array)(object)b;
            List<T> resultList = new List<T>();

            foreach (var item in arrayA)
            {
                resultList.Add((T)(object)item);
            }
            foreach (var item in arrayB)
            {
                resultList.Add((T)(object)item);
            }

            return (T)(object)resultList.ToArray();
        }
        else
        {
            throw new InvalidOperationException("Kiểu dữ liệu không được hỗ trợ");
        }
    }
}

public class ArrayProcessor
{
    public int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];
        
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 10001); // Sinh số ngẫu nhiên từ 1 đến 10000
        }

        return array;
    }

    public int FindMax(int[] array)
    {
        int max = array[0];
        foreach (var num in array)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }

    public int FindMin(int[] array)
    {
        int min = array[0];
        foreach (var num in array)
        {
            if (num < min)
            {
                min = num;
            }
        }
        return min;
    }
}



class Program
{
    static void Main(string[] args)
    {
        GenericAdder adder = new GenericAdder();
        ArrayProcessor processor = new ArrayProcessor();
        Stopwatch stopwatch = new Stopwatch();

        int a = 5, b = 10;
        stopwatch.Start();
        var sum = adder.Add(a, b);
        stopwatch.Stop();
        Console.WriteLine($"Cộng số nguyên: {sum}, Thời gian: {stopwatch.ElapsedTicks} ticks");

        string str1 = "Hello ", str2 = "World!";
        stopwatch.Restart();
        var concatenatedString = adder.Add(str1, str2);
        stopwatch.Stop();
        Console.WriteLine($"Nối chuỗi: {concatenatedString}, Thời gian: {stopwatch.ElapsedTicks} ticks");

        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };
        stopwatch.Restart();
        var mergedArray = adder.Add(array1, array2);
        stopwatch.Stop();
        Console.WriteLine($"Cộng mảng, Thời gian: {stopwatch.ElapsedTicks} ticks");

        int[] randomArray = processor.GenerateRandomArray(1000);
        stopwatch.Restart();
        int max = processor.FindMax(randomArray);
        stopwatch.Stop();
        Console.WriteLine($"Số lớn nhất: {max}, Thời gian: {stopwatch.ElapsedTicks} ticks");

        stopwatch.Restart();
        int min = processor.FindMin(randomArray);
        stopwatch.Stop();
        Console.WriteLine($"Số nhỏ nhất: {min}, Thời gian: {stopwatch.ElapsedTicks} ticks");
    }
}
