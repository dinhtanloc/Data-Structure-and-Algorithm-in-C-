using System;
using System.Text;
namespace Program
{

class Course
{
    private double[] scores;
    private int count;

    public Course(int size)
    {
        scores = new double[size];
        count = 0;
    }

    public void AddScore(double score)
    {
        if (count < scores.Length)
        {
            scores[count] = score;
            count++;
        }
        else
        {
            Console.WriteLine("Không thể thêm điểm. Môn học đã đủ số lượng điểm.");
        }
    }

    public double CalculateAverage()
    {
        double total = 0;
        for (int i = 0; i < count; i++)
        {
            total += scores[i];
        }
        return count > 0 ? total / count : 0;
    }

    public double GetHighestScore()
    {
        double highest = double.MinValue;
        for (int i = 0; i < count; i++)
        {
            if (scores[i] > highest)
                highest = scores[i];
        }
        return highest;
    }

    public double GetLowestScore()
    {
        double lowest = double.MaxValue;
        for (int i = 0; i < count; i++)
        {
            if (scores[i] < lowest)
                lowest = scores[i];
        }
        return lowest;
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Course mathCourse = new Course(5);
        mathCourse.AddScore(8.5);
        mathCourse.AddScore(9.0);
        mathCourse.AddScore(7.5);
        
        Console.WriteLine("Điểm trung bình: " + mathCourse.CalculateAverage());
        Console.WriteLine("Điểm cao nhất: " + mathCourse.GetHighestScore());
        Console.WriteLine("Điểm thấp nhất: " + mathCourse.GetLowestScore());
    }
}
}
