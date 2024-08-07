using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace calctask

{
    class employee
    {
        private string employeename;
        private int employeeid;
        private int employeeage;
        private int employesalary;

        public employee(string employeename, int employeeid)
        {
            this.employeename = employeename;
            this.employeeid = employeeid;

        }
        public employee(string employeenmae, int employeeid, int employeage)
        {
            this.employeename= employeenmae;
            this.employeeid = employeeid;
            this.employeeage = employeage;

        }
        public employee(string employeename,int employeeid,int employeage,int employeesalary)
        {
            this.employeename = employeename;
            this.employeeid = employeeid;
            this.employeeage = employeage;
            this.employesalary = employesalary;

        }

        public  void getdetails()
        {
            Console.WriteLine("employeename:" + employeename);
            Console.WriteLine("employeeid:" + employeeid);
            Console.WriteLine("employeeage:" + employeeage);
            Console.WriteLine("employesalary" + employesalary); 
        }


        


 
    

    
}
}


