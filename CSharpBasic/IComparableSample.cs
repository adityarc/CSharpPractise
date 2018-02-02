using System;
using System.Collections.Generic;

class Employees:IComparable<Employees>
{
    public int ID { get; set; }
    public string Name { get; set; }

    public int CompareTo(Employees other)
    {
        if (this.ID > other.ID)
            return 1;
        else if (this.ID < other.ID)
            return -1;
        else
            return 0;
    }
}
public class Test
{
    static void Main(string[] args)
    {
        List<Employees> list = new List<Employees>();
        list.Add(new Employees { ID = 3, Name = "Bathri" });
        list.Add(new Employees { ID = 2, Name = "athri" });
        list.Add(new Employees { ID = 1, Name = "Cathri" });
        list.Sort();
        foreach(Employees i in list)
        {
            Console.WriteLine(i.ID + "\t" + i.Name);
        }
    }
}
