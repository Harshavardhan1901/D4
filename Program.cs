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

            ////Arrays
            //int[] marks = new int[5];
            //Console.WriteLine("Enter Marks");
            //for(int i = 0; i < marks.Length; i++)
            //{
            //    Console.WriteLine("Enter marks in Subject "+(i+1));
            //    marks[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("*Marks List*");
            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.WriteLine($"Subject {i + 1} \t Marks: {marks[i]}");
            //}
            //Console.ReadKey();


            //Console.WriteLine("Enter Number of Students");
            //int nos = int.Parse(Console.ReadLine());
            //string[] students = new string[nos];
            //for (int i = 0; i < nos; i++) 
            //{
            //    Console.WriteLine($"Enter Students{i+1}\'s name");
            //    students[i] = Console.ReadLine();
            //}
            //Console.WriteLine("List of Students");
            //foreach(string student in students)
            //{ Console.WriteLine(student); }
            //Console.ReadKey();

            ////Rect Array Ex1
            //string[,] myRectArray = new string[4, 3];
            //for (int i = 0; i < myRectArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myRectArray.GetLength(1); j++)
            //    {
            //        myRectArray[i, j] = "[" + i + "," + j + "]";
            //    }
            //}
            //Console.WriteLine("stored values are: ");
            //for (int i = 0; i < myRectArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myRectArray.GetLength(1); j++)
            //    {
            //        Console.Write(myRectArray[i, j] + "\t");

            //    }
            //    Console.WriteLine("\n");

            //}
            //Console.ReadKey();

            ////Rect Array Ex2
            //int[,] marks = new int[4, 3];
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine($"Enter Student {i+1}\'s Roll Number");
            //    marks[i,0] = int.Parse(Console.ReadLine());
            //    for (int j = 1; j < 3; j++)
            //    {
            //        Console.WriteLine($"Enter marks of Students\'s{i+1} in Sem {j}");
            //        marks[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Marks List as follows");
            //Console.WriteLine("RollNo\tSemOne\tSemTwo");
            //for (int i=0; i < 4; i++)
            //{
            //    for (int j=0; j < 3; j++)
            //    {
            //        Console.Write(marks[i,j]+" \t");
            //    }
            //    Console.WriteLine("\n");
            //}
            //Console.ReadKey();

            //Rect Array Ex3
            int[][] myJArray = new int[3][];
            myJArray[0] = new int[3] { 10, 11, 12 };
            myJArray[1] = new int[5] { 1, 2, 3, 4, 5 };
            myJArray[2] = new int[2] { 1, 2 };
            for (int i = 0; i < myJArray.Length; i++)
            {
                for (int j = 0; j < myJArray[i].Length; j++)
                { Console.Write(myJArray[i][j] + "\t"); }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
