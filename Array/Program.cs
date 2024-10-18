using System;
using System.Text;

class Program
{
    static int[] Union(int[] a, int[] b)
    {
        int[] temp = new int[a.Length + b.Length];
        int index = 0;

        for (int i = 0; i < a.Length; i++)
        {
            temp[index] = a[i];
            index++;
        }
        for (int j = 0; j < b.Length; j++)
        {
            bool exists = false;
            for (int k = 0; k < a.Length; k++)
            {
                if (b[j] == a[k])
                {
                    exists = true;
                    break;
                }
            }

            if (!exists)
            {
                temp[index] = b[j];
                index++;
            }
        }

        int[] result = new int[index];
        Array.Copy(temp, result, index);

        return result;
    }

   

    // static Array Union(Array a, Array b)
    // {
    //     int lengthA = a.Length;
    //     int lengthB = b.Length;
    //     int[] result = new int[lengthA + lengthB];

    //     Array.Copy(a, result, lengthA);
    //     Array.Copy(b, 0, result, lengthA, lengthB);

    //     return result;
    // }

    static Array Intersection(Array a, Array b)
    {
        int[] temp = new int[Math.Min(a.Length, b.Length)];
        int count = 0;

        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < b.Length; j++)
            {
                if ((int)a.GetValue(i) == (int)b.GetValue(j))
                {
                    bool alreadyExists = false;

                    for (int k = 0; k < count; k++)
                    {
                        if (temp[k] == (int)a.GetValue(i))
                        {
                            alreadyExists = true;
                            break;
                        }
                    }

                    if (!alreadyExists)
                    {
                        temp[count] = (int)a.GetValue(i);
                        count++;
                    }
                }
            }
        }

        int[] result = new int[count];
        Array.Copy(temp, result, count);

        return result;
    }

    static int[] Intersection(int[] a, int[] b)
    {
        int[] temp = new int[Math.Min(a.Length, b.Length)];
        int index = 0;

        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < b.Length; j++)
            {
                if (a[i] == b[j])
                {
                    bool exists = false;
                    for (int k = 0; k < index; k++)
                    {
                        if (temp[k] == a[i])
                        {
                            exists = true;
                            break;
                        }
                    }

                    if (!exists)
                    {
                        temp[index] = a[i];
                        index++;
                    }
                    break; 
                }
            }
        }

        int[] result = new int[index];
        Array.Copy(temp, result, index);

        return result;
    }

    static Array Subtraction(Array a, Array b)
    {
        int[] temp = new int[a.Length];
        int count = 0;

        for (int i = 0; i < a.Length; i++)
        {
            bool found = false;
            for (int j = 0; j < b.Length; j++)
            {
                if ((int)a.GetValue(i) == (int)b.GetValue(j))
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                temp[count] = (int)a.GetValue(i);
                count++;
            }
        }

        int[] result = new int[count];
        Array.Copy(temp, result, count);

        return result;
    }

    static void Print(Array x, string s)
    {
        Console.WriteLine(s);
        foreach (var item in x)
        {
            Console.Write("{0,3} ", item);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Random rand = new Random(); 

        int[] ar1 = new int[5];
        for (int i = 0; i < ar1.Length; i++)
        {
            ar1[i] = rand.Next(1, 10);
        }

        int[] ar2 = new int[5];
        for (int i = 0; i < ar2.Length; i++)
        {
            ar2[i] = rand.Next(1, 10);
        }

        Print(ar1, "Array A:");
        Print(ar2, "Array B:");

        Array unionArray = Union(ar1, ar2);
        Array intersectionArray = Intersection(ar1, ar2);
        Array subtractionArray = Subtraction(ar1, ar2);

        Print(unionArray, "Union:");
        Print(intersectionArray, "Intersection:");
        Print(subtractionArray, "Subtraction:");
    }
}
