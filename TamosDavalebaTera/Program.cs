using System;
  class HomeWork4
  {
     static void Main(string[] args)
     {
        Console.ReadLine();
     }
    // შევქმნათ მეთოდი, რომელსაც გადავცემთ ორ სრულ რიცხვს. მეთოდმა უნდა დააბრუნოს ორი რიცხვის ჯამი. გამოვიყვანოთ ეს ჯამი შესვლის წერტილის მეთოდის მეშვეობით კონსოლში.
    static int getSum(int x, int y)
    { return x + y; }
    // შევქმნათ მეთოდი. ვთხოვოთ მომხმარებელს შეიყვანოს ოთხი ნებისმიეირ ტიპის რიცხვი (ანუ არა მხოლოდ ინტეჯერი). მეთოდის ფარგლებში უნდა მოიძებნოს ამ ოთხი რიცხვიდან ყველაზე დიდი და ყველაზე პატარა. მეთოდმა უნდა გამოიყვანოს კონსოლში ეს ორი რიცხვი.

    static void GetParms()
    {
        Console.WriteLine("please write number1:");
        decimal number1 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("please wtite number2:");
        decimal number2 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("please write number3:");
        decimal number3 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("please write number4:");
        decimal number4 = decimal.Parse(Console.ReadLine());

        if (number1 >= number2 && number1 >= number3 && number1 >= number4)
        {
            Console.WriteLine("The largest number is: " + number1);
        }
        else if (number2 >= number1 && number2 >= number3 && number2 >= number4)
        {
            Console.WriteLine("The largest number is: " + number2);
        }
        else if (number3 >= number1 && number3 >= number2 && number3 >= number4)
        {
            Console.WriteLine("The largest number is:" + number3);
        }
        else if (number4 >= number1 && number4 >= number2 && number4 >= number3)
        {
            Console.WriteLine("The largest number is: " + number4);
        }
        else
        {
            Console.WriteLine("These numbers is equal");
        }


        if (number1 <= number2 && number1 <= number3 && number1 <= number4)
        {
            Console.WriteLine("The smallest number is: " + number1);
        }
        else if (number2 <= number1 && number2 <= number3 && number2 <= number4)
        {
            Console.WriteLine("The smallest number is: " + number2);
        }
        else if (number3 <= number1 && number3 <= number2 && number3 <= number4)
        {
            Console.WriteLine("The smallest number is:" + number3);
        }
        else if (number4 <= number1 && number4 <= number2 && number4 <= number3)
        {
            Console.WriteLine("The smallest number is: " + number4);
        }
        else
        {
            Console.Write("");
        }
    }
    //  შევქმნათ მეთოდი, რომელმაც უნდა მიიღოს მეორე მეთოდის მეშვეობით მომხმარებლისგან ხილის დასახელება. ამ ხილის დასახელების მიღების შემდეგ switch ოპერატორის მეშვეობით ნახოს თუ რომელი ხილია და გამოიყვანოს შესაბამისი შეტყობინება. თუ ასეთი ხილი არ მოიძებნა, ამის შესახებაც მომხმარებელმა უნდა მიიღოს შეტყობინება. ხილი: apple, watermelon, melon, cherry, strawberry.
    static void getParms()
    {
        Console.WriteLine("enter fruits");
        Console.Write("apple,watermelon, melon, cherry, strawberry");
        string fruits = Console.ReadLine();

        switch (fruits)
        {
            case "apple":
                Console.WriteLine("you enter an apple");
                break;
            case "watermelon":
                Console.WriteLine("you enter a watermelon");
                break;
            case "melon":
                Console.WriteLine("you enter a melon");
                break;
            case "cherry":
                Console.WriteLine("you enter a cherry");
                break;
            case "straberry":
                Console.WriteLine("you enter a strawberry");
                break;
            default:
                Console.WriteLine("you enter wrong fruits");
                break;
        }
    }
  }