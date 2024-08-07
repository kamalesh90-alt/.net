using OopsDemo;

internal class Program
{
    private static void Main(string[] args)



    {
        //employee e1, e2;
        //e1 = new employee();
        //e2 = new employee();

        //employee.companyname = "cts";


        //e1.employeename = "kamalesh";
        //e1.employeeage = 23;
        //e1.employeesalary = 90000;


        //e2.employeename = "rocky";
        //e2.employeeage = 24;
        //e2.employeesalary = 800000;


        //Console.WriteLine("employee name :" + e1.employeename);
        //Console.WriteLine("employee age :" + e1.employeeage);
        //Console.WriteLine("employee salary :" + e1.employeesalary);
        //Console.WriteLine("employee name :" + e2.employeename);
        //Console.WriteLine("employee age :" + e2.employeeage);
        //Console.WriteLine("employee salary :" + e2.employeesalary);
        //Console.WriteLine("company name :" + employee.companyname);


        user1 u1;

        Console.Write("Enter username : ");
        string uname = Console.ReadLine();
        Console.Write("Enter Password : ");
        string password = Console.ReadLine();
        u1 = new user1(uname, password);
        Console.WriteLine("result");
         u1.CheckLogin();




    }
}

