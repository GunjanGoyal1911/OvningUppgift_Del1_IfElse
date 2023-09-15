namespace ÖvningIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
             /*//Even or Odd::
             Console.WriteLine("Plesae enter a number");
             int number = Convert.ToInt32(Console.ReadLine());
             if(number % 2 == 0)
             {
                 Console.WriteLine("The number is even.");
             }
             else
             {

                 Console.WriteLine("The number is odd.");
             }


           

             //####################################################3333

             //Age Bracket:
             Console.WriteLine("Please enter the age::");
             int age = Convert.ToInt32(Console.ReadLine());
             if (age < 13)
             {
                 Console.WriteLine("You are a child");
             }
             else if (age>=13 && age<=19)
             {
                 Console.WriteLine("You are a teenager");
             }
             else 
             {
                 Console.WriteLine("You are an adult");
             }

             //##############################################
             //Grade System:

             Console.WriteLine("Please enter your score(0-100)");
             int score= Convert.ToInt32(Console.ReadLine());
             if(score>=90 && score<=100)
             {
                 Console.WriteLine("Your grade is :: A");
             }
             else if (score >= 80 && score <= 89)
             {
                 Console.WriteLine("Your grade is :: B");

             }
             else if(score >= 70 && score <= 79)
             { 
                 Console.WriteLine("Your grade is :: C");
             }
             else if(score >= 60 && score <= 69)
             {
                 Console.WriteLine("Your grade is :: D");
             }
             else 
             {
                 Console.WriteLine("Your garde is :: F");
             }

            //######################################################

            //Leap year ckecker::
            Console.WriteLine("Please enter the year::");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("This year is a leap year");
                    }
                    else
                    {
                        Console.WriteLine("This year is not a leap year");

                    }
                }
            }
            else
            {
                Console.WriteLine("This year is not a leap year");
            }

            // if (year%4==0 && year%400==0)|| (year%4==0 && !(year%100==0))
            //  {

            //    Console.WriteLine( "Leap year");
            //}
            //else
            //{
            //    Console.WriteLine(  "Not a leap year");
            //}


            //###############################################################

            //Maximum of Three:

            Console.WriteLine(  "Please enter three numbers::");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 >= number2 && number1 >= number3)
            {
                Console.WriteLine("Maximum number is " + number1);
            }
            else if (number2 >= number3 && number2 >= number1)
            {
                Console.WriteLine("Maximum number is " + number2);
            }
            else
            {
                Console.WriteLine("Maximum number is " + number3);
            }

            //#########################################################
            //Positive, Negative, or Zero:

            Console.WriteLine("Please enter a number::");

            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
                Console.WriteLine("The number you have entered is a positive number");
            else if (number < 0)
                Console.WriteLine("The number you have entered is a negative number");
            else
                Console.WriteLine("The number you have entered is Zero");


            //##################################################################
            //Discount System:
            Console.WriteLine("Enter the total amount of purchase::");
            int amount= Convert.ToInt32(Console.ReadLine());
            if (amount >= 1000)
            {
                int totalAmount;
                totalAmount = amount - (amount * 10 / 100);
                Console.WriteLine("The total amount after discount is::" + totalAmount);
            }
            else 
            {
                Console.WriteLine("Sorry, you are not eligible for discount");
            }

            //##################################################################
            //Weekdays::
            Console.WriteLine("Enetr the number between (1-7) ");
            int weekNumber = Convert.ToInt32(Console.ReadLine());
            if (weekNumber == 1) Console.WriteLine("It is Monday.");    
            else if (weekNumber == 2) Console.WriteLine("It is Tueasday.");
            else if (weekNumber == 3) Console.WriteLine("It is Wednesday.");
            else if (weekNumber == 4) Console.WriteLine("It is Thursday.");
            else if (weekNumber == 5) Console.WriteLine("It is Friday.");
            else if (weekNumber == 6) Console.WriteLine("It is Saturday.");
            else if (weekNumber == 7) Console.WriteLine("It is Sunday.");
            else Console.WriteLine("The number is not correct.");

            //###################################################################
            //Password Checker:

            Console.WriteLine("Please enter the password::");
            string prePsw = "CSharp123";
            string postPsw = Console.ReadLine();
            if(prePsw==postPsw)
                Console.WriteLine("Access granted");
            else Console.WriteLine("Access denied");*/

            //##################################################
            //Temperature Converter:
            
            Console.WriteLine("Enter your choice to convert the temperature::");
            Console.WriteLine("Enetr 1 for convert from Fahrenheit to Celsius:");
            Console.WriteLine("Enetr 2 for convert from Celsius to Fahrenheit");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Please enter the temperature in Fahrenheit::");
                Double f = Convert.ToDouble(Console.ReadLine());
                Double celcius = (f - 32) * 5/9;
                Console.WriteLine("Temperature in celcius::" + celcius);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Please enter the temperature in celcius::");
                Double c = Convert.ToDouble(Console.ReadLine());
                Double fahrenheit = c * 9 / 5 + 32;
                Console.WriteLine("Temperature in fahranheit:" + fahrenheit);
            }
            else 
            {
                Console.WriteLine("Invalid choice");
            }


            Console.ReadKey();

            
        }
    }
}