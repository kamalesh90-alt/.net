// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Data.SqlTypes;

Console.WriteLine("Hello, World!");


int marks = 76;

if (marks >= 75)
{
    Console.WriteLine("Distinction");
}
else if (marks >= 60 && marks < 75)
{
    Console.WriteLine("First Class");
}
else if (marks >= 50 && marks < 60)
{
    Console.WriteLine("Second class");
}
else if (marks >= 35 && marks < 50)
{
    Console.WriteLine("Third Class");
}
else
{
    Console.WriteLine("Fail...");
}


int num1 = 20;
int num2 = 30;
int num3 = 40;
if (num1 > num2 && num1 > num3)
{
    System.Console.WriteLine("num1 is greater than");
}

else if (num2 > num1 && num2 > num3)
{
    System.Console.WriteLine("num2 is greater than");
}
else
{
    System.Console.WriteLine("num3 is greater than");
}


string monthname = "";
int monthno = 44;

switch (monthno)
{
    case 1: monthname = "january"; break;
    case 2: monthname = "february"; break;
    case 3: monthname = "march"; break;
    case 4: monthname = "april"; break;
    case 5: monthname = "may"; break;
    case 6: monthname = "june"; break;
    case 7: monthname = "july"; break;
    case 8: monthname = "august"; break;
    case 9: monthname = "september"; break;
    case 10: monthname = "october"; break;
    case 11: monthname = "november"; break;
    case 12: monthname = "december"; break;
    default: monthname = "wrong month entered"; break;

}
Console.WriteLine(monthname);


//int num = 6;
//int fact = 1;

//while (num > 1)
//{
//    fact *= num;
//    num--;

//}
//Console.WriteLine("factorial of 6 is " + fact);



//int i = 0;
//int sumOfOdds = 0;
//do
//{
//    if (i % 2 == 1)
//    { sumOfOdds += i; }
//    i++;
//} while (i < 100);
//Console.ForegroundColor = ConsoleColor.DarkGreen;

//Console.WriteLine("sum of odd numbers between  1 to 100 is " + sumOfOdds);


////SUM OF DIGITS

//int num = 64351;
//int temp = num;
//int value = 0;
//int sum = 0;
//while (num > 0)
//{
//    value = num % 10;
//    sum += value;
//    num = num / 10;
//}

//Console.WriteLine(sum);


//////prime numbers
// int num8 = 1;
//bool isPrime = true;

//for (int i = 2; i < num8; i++)
//{
//    if (num8 % i == 0)
//    {
//        isPrime = false;
//        break;
//    }
//}


//if (isPrime)
//{
//    Console.WriteLine(num8 + " is a prime number");
//}
//else
//{
//    Console.WriteLine(" you are wrong");
//}





    for (int i = 2; i <= 0; i++) ;

bool isprimenumberdemo = true;

