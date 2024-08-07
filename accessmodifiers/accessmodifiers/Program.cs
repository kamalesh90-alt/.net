
//ACCESS MODIFIERS IN .NET 
class Student
{
    private int std_id;
    protected int yob;
    internal int age;
    protected internal string gender;
    public string fname;

    public string getDetails()
    {
        std_id = 1;//Private members is accesible in the same class only.
        yob = 2001;//protected members is accessible in the same class and child class.
        age = 21;//Internal is accessible in same file but not other file .
        gender = "male";
        fname = "kamalesh";//public members is accessible in any class

        return "ID:" + std_id + "YOB :" + yob + " AGE :" + age + " GENDER:" + gender + "FIRST_NAME :" + fname;
    }
}

class School : Student
{
    public string schoolName;
    public string getDetailsWithSchool()
    {

        yob = 2001;//protected members is accessible in the same class and child class.
        age = 21;
        gender = "male";
        fname = "kamalesh";//public members is accessible in any class
        schoolName = "A.M.H.S.S";
        return "YOB :" + yob + " AGE :" + age + " GENDER:" + gender + "FIRST_NAME :" + fname + "SCHOOL_NAME :" + schoolName;
    }

}
class Parent
{
    public string getStudentDetails()
    {
        Student student = new Student();
        student.fname = "kamalesh";
        student.age = 21;
        student.gender = "Male";
        return "STUDENT_FNAME :" + student.fname + "STUDENT_AGE :" + student.age + "STUDENT_GENDER :" + student.gender;
    }
}

class Program
{
    private static void Main(string[] args)
    {


        Student student = new Student();
        string d1 = student.getDetails();
        Console.WriteLine(d1);
        School school = new School();
        string d2 = school.getDetailsWithSchool();
        Console.WriteLine(d2);
        Parent parent = new Parent();
        string d3 = parent.getStudentDetails();
        Console.WriteLine(d3);
    }
}