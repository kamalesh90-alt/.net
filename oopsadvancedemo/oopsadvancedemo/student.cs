using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsadvancedemo
{
    internal class student:person
    {
        public int studentid { get; set; }
        public int marks {  get; set; }

        public student(string firstname, string lastname, string gender, int studentid, int marks) : base(firstname, lastname, gender)
        {
            this.studentid = studentid;
            this.marks = marks;
        }

        public void displaystudentdetails()

        {
            base.getpersondetails();
            Console.WriteLine("student id :" + studentid);
            Console.WriteLine("marks :" + marks);
        }


    }
}
