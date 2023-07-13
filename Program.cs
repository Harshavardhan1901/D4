using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////(condition)  ?true case :false case
            //int num1, num2;
            //Console.WriteLine("Enter First Number");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Number");
            //num2 = int.Parse(Console.ReadLine());
            //var result = num1 > num2 ? "First Number is greater" : "Second Number is greater";
            //Console.WriteLine(result);
            //Console.ReadKey();

            //Arrays
            int[] marks = new int[5];
            Console.WriteLine("Enter Marks");
            for(int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Enter marks in Subject "+(i+1));
                marks[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("*Marks List*");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Subject {i + 1} \t Marks: {marks[i]}");
            }
            Console.ReadKey();
        }
    }
}
