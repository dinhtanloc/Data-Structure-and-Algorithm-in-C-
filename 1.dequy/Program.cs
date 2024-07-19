using System;

class Program
{
    // Hàm đệ quy để tính giai thừa
    static int Factorial(int n)
    {
        if (n <= 1)
            return 1;  // Điều kiện dừng: giai thừa của 0 hoặc 1 là 1
        else
            return n * Factorial(n - 1);  // Đệ quy: n * (n-1)!
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập một số nguyên dương: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Số không hợp lệ. Vui lòng nhập một số nguyên dương.");
        }
        else
        {
            int result = Factorial(number);
            Console.WriteLine($"Giai thừa của {number} là {result}");
        }
    }
    
}
