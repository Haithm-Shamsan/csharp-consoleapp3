using My_First_Class_Library;
using System;
using My_First_Class_Library;


    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hi");

        clsMyMath MyMath1 = new clsMyMath();

       
        Console.WriteLine(MyMath1.Sum(10, 20).ToString());

        Console.WriteLine(MyMath1.Sum(10, 20,30).ToString());

        Console.ReadKey();


    }
    }

