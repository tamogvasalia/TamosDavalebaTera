using System;
  class HomeWork3
  {
    static void Main(string[] args) //შესვლის წერტილი
    {
        Console.ReadLine();
    
        /// <summary>
        ///  check main text
        /// </summary>
       
        
            Console.WriteLine("pleas enter number x:");
            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("pleas enter number y:");
            int y = Int32.Parse(Console.ReadLine());

            Console.WriteLine("pleas enter number z:");
            int z = Int32.Parse(Console.ReadLine());

            int sum = x + (y * z);

            Console.WriteLine("answer is:" + sum);
            Console.WriteLine();

            // HomeWork3-2

            Console.WriteLine("please enter your Name: ");
            string Name = Console.ReadLine();

            Console.WriteLine("please enter your Surname: ");
            string Surname = Console.ReadLine();

            Console.WriteLine("please enter your Age: ");
            int Age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("please enter your Weight: ");
            decimal Weight = decimal.Parse(Console.ReadLine());

            Console.WriteLine("please enter your Height: ");
            decimal Height = decimal.Parse(Console.ReadLine());

            // HomeWorK3-3

            Console.WriteLine("please enter your weight: ");
            decimal weight = decimal.Parse(Console.ReadLine());

            Console.WriteLine("please enter your height: ");
            decimal height = decimal.Parse(Console.ReadLine());

            decimal BMI = weight / ((height / 100) * (height / 100));

            Console.WriteLine("your BMI is:" + BMI);

            Console.ReadLine();

            // Homework3-4

            Console.WriteLine(" " + "|" + "_" + "|" + " ");
            Console.WriteLine("1" + "|" + "2" + "|" + "3");
            Console.WriteLine("_" + "|" + "_" + "|" + "_");
            Console.WriteLine("4" + "|" + "5" + "|" + "6");
            Console.WriteLine("_" + "|" + "_" + "|" + "_");
            Console.WriteLine("7" + "|" + "8" + "|" + "9");
            Console.WriteLine("_" + "|" + "_" + "|" + "_");

            Console.ReadLine();

    }
  }

