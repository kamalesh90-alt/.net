using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsadvancedemo
{
    internal class employee : person
    {
        public int employeeid { get; set; }
        public int employeesalary { get; set; }

        public employee(string firstname, string lastname, string gender, int employeeid, int employeesalary) : base(firstname, lastname,gender)
        {
            this.employeeid=employeeid;
            this.employeesalary = employeesalary;
        }
        public void getemployeedetails()
        {
            base.getpersondetails();
            Console.WriteLine("employee id :" + employeeid);
            Console.WriteLine("employeesalary :" +employeesalary);

        }

        

        }
    }

