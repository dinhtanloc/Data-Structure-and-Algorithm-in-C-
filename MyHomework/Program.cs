using System.Collections;
internal class Program
//HW for array
{
static ArrayList Union(ArrayList a, ArrayList b)
{
    ArrayList temp = new ArrayList();
    foreach (var item in a)
    {
        temp.Add(item);
    }
    foreach (var item in b)
    {
        if (!temp.Contains(item))
        {
            temp.Add(item);
        }
    }
    return temp;
}

static ArrayList Intersection(ArrayList a, ArrayList b)
{
    ArrayList giaoArray = new ArrayList();
    foreach (var item in a)
    {
        if (b.Contains(item))
        {
            giaoArray.Add(item);
        }
    }
    return giaoArray;
}

static ArrayList Subtraction(ArrayList a, ArrayList b)
{
    ArrayList temp = new ArrayList();
    foreach (var item in a)
    {
        if (!b.Contains(item))
        {
            temp.Add(item);
        }
    }
    return temp;


}


 private static void Main(string[] args)
    {
        ArrayList alunion = Union(alA, alB);
        ArrayList alintersection = Intersection(alA, alB);
        ArrayList alsubtraction = Subtraction(alA, alB);

        Console.WriteLine("\nUnion (ArrayList): ");
        foreach (int val in alunion)
            Console.Write(" " + val);
        Console.WriteLine("\nIntersection (ArrayList): ");
        foreach (int val in alintersection)
            Console.Write(" " + val);
        Console.WriteLine("\nSubtraction (ArrayList): ");
        foreach (int val in alsubtraction)
        Console.Write(" " + val);

    }




}