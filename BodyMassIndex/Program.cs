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
            if (bmi<18)
            {
                Console.WriteLine("Weak");
            }
            else if (bmi >= 18 && bmi < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("Fat");
            }
            else if (bmi >= 30 && bmi < 35)
            {
                Console.WriteLine("Obese");
            }

        }
    }
}
