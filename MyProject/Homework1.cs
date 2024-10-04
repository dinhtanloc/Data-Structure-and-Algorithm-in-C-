using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
namespace Homework
{
    internal class MyCollection<T> : CollectionBase
    {
        public void Add(T item)
        {
            InnerList.Add(item);
        }

        public bool Contains(T item)
        {
            return InnerList.Contains(item);
        }

        public void Reverse()
        {
            InnerList.Reverse();
        }

        public void Reverse(){
            ArrayList temp =(ArrayList)InnerList.Clone();
            InnerList.Clear();
            foreach(T item in temp)
                InnerList.Insert(0,item);
        }

        public void SetItem(int index, T item)
        {
            if (index >= 0 && index < InnerList.Count)
            {
                InnerList[index] = item;
            }
            else
            {
                Console.WriteLine("Index out of range");
            }
        }

        public void PrintAll()
        {
            foreach (var item in InnerList)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyCollection<int> my = new MyCollection<int>();
            Stopwatch stopwatch = new Stopwatch();
            my.Add(1);
            my.Add(2);
            my.Add(3);

            stopwatch.Reset();   
            stopwatch.Start();
            Console.WriteLine(my.Contains(1)); 
            Console.WriteLine(my.Contains(5)); 
            my.Reverse();
            stopwatch.Stop();
            Console.WriteLine("Thời gian thực thi của ReverseMethod2: " + stopwatch.ElapsedMilliseconds + "ms");
            my.PrintAll();
        }
    }
}
