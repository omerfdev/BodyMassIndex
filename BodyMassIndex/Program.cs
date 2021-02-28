using System;

namespace BodyMassIndex
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Double height, weigth, bmi;
            Console.WriteLine("Welcome To Body Mass Index");
            Console.WriteLine("Please Enter Your Height");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter Your Weigth");
            weigth = Convert.ToDouble(Console.ReadLine());
            bmi = weigth / (height*height);


        }
    }
}
