using System;
using System.Text;
namespace Program2
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

class Program2
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Course[] courses = new Course[2];
        courses[0] = new Course(5); 
        courses[1] = new Course(5); 
        
        courses[0].AddScore(8.5);
        courses[0].AddScore(9.0);
        courses[0].AddScore(7.5);
        
        courses[1].AddScore(8.0);
        courses[1].AddScore(9.5);
        
        for (int i = 0; i < courses.Length; i++)
        {
            Console.WriteLine($"Môn {i + 1}: Điểm trung bình: {courses[i].CalculateAverage()}");
            Console.WriteLine($"Môn {i + 1}: Điểm cao nhất: {courses[i].GetHighestScore()}");
            Console.WriteLine($"Môn {i + 1}: Điểm thấp nhất: {courses[i].GetLowestScore()}");
        }
    }
}
}