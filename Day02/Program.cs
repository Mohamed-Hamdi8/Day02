using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //bool parsed;
            //int number;
            //do
            //{
            //    Console.Write("Enter Number : ");
            //    parsed = int.TryParse(Console.ReadLine(), out number);
            //} while (!parsed);
            //for( int i = 1; i <= number;i++)
            //{
            //    Console.Write($"{i} ");
            //}
            #endregion

            #region 2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //bool parsed;
            //int number;
            //do
            //{
            //    Console.Write("Enter Number : ");
            //    parsed = int.TryParse(Console.ReadLine(), out number);
            //} while (!parsed);
            //int Multi = 0;
            //for(int i = 0; i < 12; i++)
            //{
            //    Multi += number;
            //    Console.Write($"{Multi} ");
            //}
            #endregion

            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //bool parsed;
            //int number;
            //do
            //{
            //    Console.Write("Enter Number : ");
            //    parsed = int.TryParse(Console.ReadLine(), out number);
            //} while (!parsed);
            //for(int i = 2; i <= number; i++)
            //{
            //    if(i%2==0)
            //    Console.Write($"{i} ");
            //}
            #endregion

            #region 4- Write a program that takes two integers then prints the power.
            //bool parsed;
            //int number;
            //int power;
            //do
            //{
            //    Console.Write("Enter Number : ");
            //    parsed = int.TryParse(Console.ReadLine(), out number);
            //} while (!parsed);
            //do
            //{
            //    Console.Write("Enter power : ");
            //    parsed = int.TryParse(Console.ReadLine(), out power);
            //} while (!parsed);
            //int result = 1 ;
            //for(int i = 0; i< power; i++)
            //{
            //    result *= number;
            //}
            //    Console.WriteLine(result);
            #endregion

            #region 5- Write a program to enter marks of five subjects and calculate total, average and percentage.
            //bool parsed;
            //int mark01;
            //int mark02;
            //int mark03;
            //int mark04;
            //int mark05;
            //do
            //{
            //    Console.Write("Enter Mark Of Subjec01 : ");
            //    parsed = int.TryParse(Console.ReadLine(), out mark01);
            //} while (!parsed);
            //do
            //{
            //    Console.Write("Enter Mark Of Subjec02 : ");
            //    parsed = int.TryParse(Console.ReadLine(), out mark02);
            //} while (!parsed);
            //do
            //{
            //    Console.Write("Enter Mark Of Subjec03 : ");
            //    parsed = int.TryParse(Console.ReadLine(), out mark03);
            //} while (!parsed);
            //do
            //{
            //    Console.Write("Enter Mark Of Subjec04 : ");
            //    parsed = int.TryParse(Console.ReadLine(), out mark04);
            //} while (!parsed);
            //do
            //{
            //    Console.Write("Enter Mark Of Subjec05 : ");
            //    parsed = int.TryParse(Console.ReadLine(), out mark05);
            //} while (!parsed);

            //double SubjectMarkTotal = mark01 + mark02 + mark03 + mark04 + mark05;
            //double SubjectAvarage = SubjectMarkTotal / 5;
            //double SubjectPercentage = (SubjectMarkTotal/500) * 100;

            //Console.WriteLine($"Total Marks = {SubjectMarkTotal} \n" +
            //    $"Avarage = {SubjectAvarage} \n" +
            //    $"Percentage = {SubjectPercentage}%");
            #endregion

            #region 6- Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.Write("Enter Your Name : ");
            //string Name = Console.ReadLine();
            //for(int i = Name.Length-1; i >= 0; i--)
            //{
            //    Console.Write($"{Name[i]} ");
            //}
            #endregion

            #region 7- Write a program to allow the user to enter int and print the REVERSED of it.
            //bool parsed;
            //int number;
            //do
            //{
            //    Console.Write("Enter Number : ");
            //    parsed = int.TryParse(Console.ReadLine(), out number);
            //} while (!parsed);
            //string NumbersChar = number.ToString();
            //for (int i = NumbersChar.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{NumbersChar[i]} ");
            //}
            #endregion
        }
    }
}
