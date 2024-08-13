    using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace calctask
{
    class mathoperation
    {
        private int num1;
        private int num2;

      public mathoperation(int num1, int num2)
        {
            this.num1 = num1;

            this.num2 = num2;
        }

        public int addition()
        { return num1+num2; }

        public int subtractition() { return num1 - num2; }
        public int multiply() { return num1 * num2; }
        public double divide() { return num1 / num2; }


        public void displayoperations()

        {
            Console.WriteLine("addition "+ addition());
            Console.WriteLine("subtraction " + subtractition());
            Console.WriteLine("multiplication " + multiply());
            Console.WriteLine("division " + divide());
        }

    }
}
