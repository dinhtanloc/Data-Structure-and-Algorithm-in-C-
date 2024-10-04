using System;
using System.Collections.Generic;
using System.Text;
namespace Program3
{

class Course
{
    private List<double> scores;

    public Course()
    {
        scores = new List<double>();
    }

    public void AddScore(double score)
    {
        scores.Add(score);
    }

    public double CalculateAverage()
    {
        double total = 0;
        foreach (double score in scores)
        {
            total += score;
        }
        return scores.Count > 0 ? total / scores.Count : 0;
    }

    public double GetHighestScore()
    {
        return scores.Count > 0 ? scores.Max() : double.MinValue;
    }

    public double GetLowestScore()
    {
        return scores.Count > 0 ? scores.Min() : double.MaxValue;
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Course mathCourse = new Course();
        mathCourse.AddScore(8.5);
        mathCourse.AddScore(9.0);
        mathCourse.AddScore(7.5);
        
        Console.WriteLine("Điểm trung bình: " + mathCourse.CalculateAverage());
        Console.WriteLine("Điểm cao nhất: " + mathCourse.GetHighestScore());
        Console.WriteLine("Điểm thấp nhất: " + mathCourse.GetLowestScore());
    }
}
}