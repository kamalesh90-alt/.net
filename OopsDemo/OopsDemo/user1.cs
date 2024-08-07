using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    internal class user1
    {

        private string username;
        private string password;
        private string message;

        public user1(string username, string password, string message = "")
        {
            this.username = username;
            this.password = password;


        }

        public user1(string username,string password)
        {
            this.username=username;
            this.password=password;
        }
        public user1(string username, string password,string message)
        {
            this.username = username;
            this.password = password;
            this.message= message;
        }
        public user1(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public user1(string username,string password,string message, string address, string bool ismarried)
        {
            this.username = username;
            this.password = password;
            this.message = message;
            this.message = address;
        }

        public void getdetails()
        {
            Console.WriteLine("username : " + username);
            console.WriteLine("password : " + password);

            if(this.address!=null)
            {
                console.WriteLine("address : " + this.address);

            }
            console.writeline("")
        }

        public string CheckLogin()
        {
            if (this.username == "Admin" && this.password == "manager")

            {
                if(this.message==null)
                {
                    this.message = "you are logged in as admin";
                }
                
            }
            else if (this.username.StartsWith("User") && this.password == "Pass")
            {
                if (this.message==null)
                {
                    this.message = "you are logged in as User";
                }
                

            }
            else
            {
                if(this.message== null)
                {
                    this.message = "invalid login";
                }
               
            }
            return this.message;

        }
    }
}
