using OopsDemo;

namespace calctask;

class Program
{
    private static void Main(string[] args)
    {


        //        Console.WriteLine("enter the num1: ");
        //        int num1=int.Parse(Console.ReadLine());
        //        Console.WriteLine("enter the num2: ");
        //        int num2 = int.Parse(Console.ReadLine());

        //        mathoperation m1 = new mathoperation(num1,num2);

        //        m1.displayoperations(); 
        User u1, u2, u3, u4, u5;
        string result;
        string username = Console.ReadLine();
        string password = Console.ReadLine();
        u1 = new User(username,password);

        u1.getDetails();
        result = u1.CheckLogin();
        Console.WriteLine(result);
        u2 = new User("Pankaj", "kalra", "Guest User");
        u2.getDetails();
        result = u2.CheckLogin();
        Console.WriteLine(result);
        u3 = new User("Admin", "Manager", "Guest User", "Nagpur");
        u3.getDetails();
        result = u3.CheckLogin();
        Console.WriteLine(result);
        u4 = new User("Admin", "Manager");
        u4.getDetails();
        result = u4.CheckLogin();
        Console.WriteLine(result);

    }
}