internal class Program
{
    private static void Main(string[] args)
    {

        Dictionary<int, string> empdetails;

        empdetails = new Dictionary<int, string>();

        empdetails.Add(100, "kamal");

        empdetails.Add(102, "maddy");

        empdetails.Add(103, "Manasa");

        string ename = empdetails[100];

        Console.WriteLine(ename);

        SortedList<string, int> Marks;

        Marks = new SortedList<string, int>();

        Marks.Add("Maths", 80);

        Marks.Add("Physics", 90);

        Marks.Add("English", 65);

        Marks.Add("Chemistry", 75);

        foreach (string key in Marks.Keys)
        {

            Console.WriteLine(key + " " + Marks[key]);

        }
        Console.WriteLine(Marks["Maths"] +" " +"Maths");

        Marks.Append;
        
    }
}