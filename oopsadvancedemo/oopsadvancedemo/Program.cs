using oopsadvancedemo;

internal class Program
{
    private static void Main(string[] args)
    {
        person p = new person("kamalesh", "maddy", "m");
        //p.firstname = "kamalesh";
        //p.lastname = "maddy";
        //p.gender = "m";

        p.getpersondetails();

        student s = new student("randy", "orten", "m", 1,90);
        //s.firstname = "randy";
        //s.lastname = "orten";
        //s.gender = "m";
        //s.studentid = 1;
        //s.marks = 90;
        s.displaystudentdetails();

        employee e = new employee("batista","roman reings","m",1, 90000);
        e.firstname = "batista";
        e.lastname = "roman reings";
        e.gender = "m";
        e.employeeid = 1;
        e.employeesalary = 90000;
        e.getemployeedetails();
        //console.writeline("name :" + e.firstname + " " + e.lastname);
        //console.writeline("gender :" + e.gender);
        //console.writeline("employee id :" + e.employeeid);
        //console.writeline("employeesalary :" + e.employeesalary);
        //console.writeline("\n");



    }
}