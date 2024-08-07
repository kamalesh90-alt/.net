using System;
using System.Data.Common;
using System.Formats.Asn1;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        //Console.WriteLine("Hello, World!");
        //System.Console.ReadKey();
        //Console.WriteLine("welcome to the .net class");
        //System.Console.ReadKey();


        //int num = 10;
        //Console.WriteLine(num);

        sbyte a = 10;
        byte b = 20;
        short s = 30;
        ushort d = 40;
        int e = 50;
        uint f = 70;
        long g = 55;
        ulong h = 60;
        float i = 90.23f;
        double j = 100.234234;
        decimal k = 110.2342324M;

        uint min = uint.MinValue;
        uint max = uint.MaxValue;

        //Console.WriteLine(max);
        //Console.WriteLine(min);

        char ch = 'A';
        string str = "hello 123$&";
        Console.WriteLine(str);
        */


        //*****operators*****//


        //int num1 = 10;
        //int num2 = 20;
        //Console.WriteLine(num1 + num2);
        //Console.WriteLine(num1 - num2);
        //Console.WriteLine(num2 * num1);
        //Console.WriteLine(num1 / num2);
        //Console.WriteLine(num1 % num2);


        //Console.WriteLine(num1 += num2);
        //Console.WriteLine(num1 -= num2);
        //Console.WriteLine(num2 *= num1);
        //Console.WriteLine(num1 /= num2);
        //Console.WriteLine(num1 %= num2);


        //int x = 10, y = 20, z = 10;
        //bool result1=((x==y)) && (y==z);
        //Console.WriteLine(result1);
        //bool result2 = ((x == y) || (y > z));
        //Console.WriteLine(result2);

        //bool result3 = !result1;
        //Console.WriteLine(result3);


        //string str1 = "GM";
        //string str2 = "welcome to .net class";
        //Console.WriteLine(str1 + " " + str2);

        //int num = 10;
        //Console.WriteLine(str1 + num);



        //int num = 12;
        //string result = ((num % 2 == 0) ? "even" : "odd");
        //if(num%2==0)
        //{
        //    Console.WriteLine(num + "is even number");

        //}
        //else
        //{
        //    Console.WriteLine(num + "is odd number");
        //}




        int x = 2025;
        if (x % 100 != 0 && x%4==0)
        {
            Console.WriteLine(x + "this is leap year");
        }
        else if ((x % 400 == 0))
        {
            Console.WriteLine(x + "not a leap year");
        }
        else
        {
            Console.WriteLine(x + "is not leap year");
        }



    }
} 
             






