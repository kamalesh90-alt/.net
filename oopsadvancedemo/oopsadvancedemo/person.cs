using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsadvancedemo
{
    internal class person
    {
        public string firstname {  get; set; }
        public string lastname { get; set; }
        public string gender {  get; set; }

        public person(string firstname,string lastname, string gender)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
        }
        public void getpersondetails()
        {
            Console.WriteLine("firstname :" + firstname);
            Console.WriteLine("lastname :" + lastname);
            Console.WriteLine("gender :" + gender);
        }
    }
}
