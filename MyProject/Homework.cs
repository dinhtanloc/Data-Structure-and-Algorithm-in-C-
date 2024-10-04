using System;
using System.Collections;
using System.Collections.Generic;
namespace Homework{
    class Homework{
        static T Sum<T> (T a, T b){
                if (((dynamic)a).GetType().ToString().IndexOf("[]")>=0)
                {
                    object[] result = new object[
                        ((dynamic)a).Length +((dynamic)b).Length];
                    int index=0;
                    foreach(object o in (dynamic)a)
                        result[index++]=o;
                    foreach(object o in (dynamic)b)
                        result[index++]=o;
                    return (dynamic)result;
                }
                else
                {
                    return (dynamic)a + (dynamic)b;
                }
        
        }
        static void Main(){
            int a=2;
            int b=3;
            Console.WriteLine(Sum(a,b));
            Console.WriteLine(Sum(2.5,3.5));
            Console.WriteLine(Sum("a","b"));
            object[] array1 = { 1, 2, 3 };
            object[] array2 = { 4, 5, 6 };
            var resultArray = Sum(array1, array2);  

            Console.WriteLine(string.Join(", ", resultArray)); 

        }
    }

}