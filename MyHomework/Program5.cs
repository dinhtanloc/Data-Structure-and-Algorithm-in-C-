using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
namespace MyNamespace
{

class Program5
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int n = 100000; 

        Stopwatch stopwatchArray = Stopwatch.StartNew();
        double[] scoresArray = new double[n];
        for (int i = 0; i < n; i++)
        {
            scoresArray[i] = i % 100; 
        }
        stopwatchArray.Stop();
        Console.WriteLine($"Thời gian thực thi với Array: {stopwatchArray.ElapsedMilliseconds} ms");

        Stopwatch stopwatchList = Stopwatch.StartNew();
        List<double> scoresList = new List<double>();
        for (int i = 0; i < n; i++)
        {
            scoresList.Add(i % 100); 
        }
        stopwatchList.Stop();
        Console.WriteLine($"Thời gian thực thi với List: {stopwatchList.ElapsedMilliseconds} ms");

        Stopwatch stopwatchArrayList = Stopwatch.StartNew();
        ArrayList scoresArrayList = new ArrayList();
        for (int i = 0; i < n; i++)
        {
            scoresArrayList.Add(i % 100); 
        }
        stopwatchArrayList.Stop();
        Console.WriteLine($"Thời gian thực thi với ArrayList: {stopwatchArrayList.ElapsedMilliseconds} ms");
    }
}
}