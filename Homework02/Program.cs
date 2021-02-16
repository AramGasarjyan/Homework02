using System;
using System.Collections.Generic;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {

            //String Compression

            //string sentence = "aabccccaaa";
            //StringCompression(sentence);


            //URLify


            //string sentence = "What’s new in C#8.0";
            //URLify(sentence);

            // Days in a Month

            //Console.Write("Please input the month number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //DaysInMonth(number);

            // Grade Mapping

            //Console.Write("Input the mark of student: ");
            //int mark = Convert.ToInt32(Console.ReadLine());
            //gradeMapping(mark);


            // Calculator 

            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.Write("Input the first integer: ");

            //Console.ForegroundColor = ConsoleColor.Red;
            //double number1 = Convert.ToInt32(Console.ReadLine());

            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.Write("Input the first integer: ");

            //Console.ForegroundColor = ConsoleColor.Red;
            //double number2 = Convert.ToInt32(Console.ReadLine());

            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.Write("Choose one of the options: 1-Addition, 2-Subtraction, 3-Multiplication, 4-Division, 5-Exit: ");

            //Console.ForegroundColor = ConsoleColor.Red;
            //int action = Convert.ToInt32(Console.ReadLine());

            //Console.ForegroundColor = ConsoleColor.Blue;
            //switch (action)
            //{
            //    case 1:
            //        Console.Write($"The addition is: {number1 + number2}");
            //        break;
            //    case 2:
            //        Console.Write($"The subtraction is: {number1 - number2}");
            //        break;
            //    case 3:
            //        Console.Write($"The multiplication is: {number1 * number2}");
            //        break;
            //    case 4:
            //        Console.Write($"The division is: {number1 / number2}");
            //        break;
            //    case 5:
            //        break;
            //    default:
            //        Console.WriteLine("Your choice is incorrect");
            //        break;
            //}
        }

        //static void gradeMapping(int mark)
        //{
        //    if (mark == 10)
        //    {
        //        Console.WriteLine("Your grade is: A++");
        //    }
        //    else if (mark == 9)
        //    {
        //        Console.WriteLine("Your grade is: A");
        //    }
        //    else if (mark == 7 || mark == 8)
        //    {
        //        Console.WriteLine("Your grade is: B");
        //    }
        //    else if (mark == 6)
        //    {
        //        Console.WriteLine("Your grade is: C");
        //    }
        //    else if (mark == 5)
        //    {
        //        Console.WriteLine("Your grade is: D");
        //    }
        //    else if (mark >= 0 && mark <= 4)
        //    {
        //        Console.WriteLine("Your grade is: F");
        //    }
        //}

        //static void DaysInMonth(int number)
        //{
        //    switch (number)
        //    {
        //        case 1:
        //            Console.WriteLine("It is January - 31 days.");
        //            break;
        //        case 2:
        //            Console.WriteLine("February - 28 days in a common year and 29 days in leap years.");
        //            break;
        //        case 3:
        //            Console.WriteLine("It is March - 31 days.");
        //            break;
        //        case 4:
        //            Console.WriteLine("It is April - 30 days.");
        //            break;
        //        case 5:
        //            Console.WriteLine("It is May - 31 days.");
        //            break;
        //        case 6:
        //            Console.WriteLine("It is June - 30 days.");
        //            break;
        //        case 7:
        //            Console.WriteLine("It is July - 31 days.");
        //            break;
        //        case 8:
        //            Console.WriteLine("It is August - 31 days.");
        //            break;
        //        case 9:
        //            Console.WriteLine("It is September - 30 days");
        //            break;
        //        case 10:
        //            Console.WriteLine("It is October - 31 days");
        //            break;
        //        case 11:
        //            Console.WriteLine("It is November - 30 days.");
        //            break;
        //        case 12:
        //            Console.WriteLine("It is December - 31 days");
        //            break;
        //    }
        //}

        //static void URLify(string sentence)
        //{
        //    string newstring = "";
        //    for (int i = 0; i < sentence.Length; i++)
        //    {
        //        if (sentence[i] == ' ')
        //        {
        //           newstring += "%20";
        //        }
        //        else
        //        {
        //            newstring += sentence[i];
        //        }
        //    }
        //    Console.WriteLine(newstring);
        //}

        //static void StringCompression(string sentence)
        //{
        //    char[] a = new char[100];
        //    for (int i = 0; i < sentence.Length; i++)
        //    {
        //        int count = 0;

        //        for (int j = 0; j < sentence.Length; j++)
        //        {
        //            if (a[j] == sentence[i])
        //            {
        //                break;
        //            }
        //            if (sentence[i] == sentence[j])
        //            {
        //                a[i] = sentence[i];
        //                count++;
        //            }
        //            if (j == sentence.Length - 1)
        //            {
        //                Console.Write(sentence[i]);
        //                Console.Write(count);
        //            }

        //        }
        //    }
        //}
    }
}
