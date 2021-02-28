using System;

namespace BodyMassIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("{0:r}", DateTime.Now);
            
            OMERFDEV:
            int height, weigth, bmi;
            Console.WriteLine("Welcome To Body Mass Index");
            Console.WriteLine("Please Enter Your Height");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Your Weigth");
            weigth = Convert.ToInt32(Console.ReadLine());
            bmi = (weigth/((height * height)/10000));
            if (bmi <= 18) 
            {
                Console.WriteLine("Weak");
                goto OMERFDEV;
            }
            else if (bmi >= 18 && bmi < 25)
            {
                Console.WriteLine("Normal");
                goto OMERFDEV;
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("Fat");
                goto OMERFDEV;
            }
            else if (bmi >= 30 && bmi < 35)
            {
                Console.WriteLine("Obese");
                goto OMERFDEV;
            }
            else
            {
                Console.WriteLine("Serious Obese");
                goto OMERFDEV;
            }
           
        }
    }
}
