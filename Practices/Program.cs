using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using ConsoleTables;
using Microsoft.VisualBasic;

namespace Exercise
{

    public class program
    {


        static void Main()
        {

            // 1 Hello WOrld
            /*
            Console.WriteLine("Hellow World");
            */

            // 2 Name/Surname output via string use

            /*
            string name = "John";
            string surname = "Lewis";

            Console.WriteLine(name + " " + surname);
            */

            // 3 Sum of 2 numbers
            /*
            int num1, num2, addition;
            Console.WriteLine("First Num : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Num : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            addition = num1 + num2;
            Console.WriteLine($"addition of {num1} and {num2} is {addition} "  );
            */

            // 4 Calculation of 2 numbers (addition1, subtraction, division, multiplication)

            /*
            int num3, num4, addition1, subtraction, division, multiplication;
            Console.WriteLine("First Num :");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Num : ");
            num4 = Convert.ToInt32(Console.ReadLine());
            addition1 = num3 + num4;  subtraction = num3 - num4; division = num3 / num4; multiplication = num3 * num4;
            Console.WriteLine($"addition of {num3} and {num4} is {addition1} ");
            Console.WriteLine($"subtraction of {num3} and {num4} is {subtraction} ");
            Console.WriteLine($"division of {num3} and {num4} is {division} ");
            Console.WriteLine($"multiplication of {num3} and {num4} is {multiplication} ");
            */

            // 5 Calculationg 18 percent of a number.

            /*
            int num5 , percent;
            Console.WriteLine("Number : ");
            num5 = Convert.ToInt32(Console.ReadLine());
            percent = ( num5 * 18 ) / 100;
            Console.WriteLine($"18 percent of the {num5} is {percent} ");
            */

            // 6 Calculationg percent of a number via input from user.

            /*
            double num6, percent1, result;
            Console.WriteLine("Number : ");
            num6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Percent : ");
            percent1 = Convert.ToDouble(Console.ReadLine());
            result = num6 * percent1 / 100;
            Console.WriteLine($"Sayının Yüzdesi : {result} ");
            */


            // 7 Calculation of total profit.

            /*
            double purchase_price, profit_rate, sale_price, profit_principal;
            Console.WriteLine("Purchase Price : ");
            purchase_price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Profit Rate : ");
            profit_rate = Convert.ToDouble(Console.ReadLine());
            sale_price = purchase_price * profit_rate / 100;
            profit_principal = sale_price + purchase_price;
            Console.WriteLine($"Addition of purchase price and profit = {profit_principal}");
            */

            // 8 Calculation of area , perimeter of a square
            /*
            int  long_edge , short_edge , area, perimeter;
            Console.WriteLine("Long Edge : ");
            long_edge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Short Edge : ");
            short_edge = Convert.ToInt32(Console.ReadLine());
            area = long_edge * short_edge;
            perimeter = (long_edge + short_edge) * 2;
            Console.WriteLine($"Area of square is {area}");
            Console.WriteLine($"Perimeter of square is {perimeter}");
            */

            // 9 Calculation of area , perimeter of a triangle

            /*
            double radious , pi ,area_triangle , perimeter_triangle;
            pi = 3.14;
            Console.WriteLine("Radious : ");
            radious = Convert.ToDouble(Console.ReadLine());  
            area_triangle = 2 * pi * radious;
            perimeter_triangle = pi * (radious * radious);
            Console.WriteLine($"Area of triangle is {area_triangle.ToString("00.0")} ");
            Console.WriteLine($"Area of triangle is {perimeter_triangle}");
            */

            // 10 Calculating of average of exams and class pass statue

            /*
            int exam1 , exam2 , exam3 , average ;
            Console.WriteLine("Exam 1 : ");
            exam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Exam 2 : ");
            exam2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Exam 3 : ");
            exam3 = Convert.ToInt32(Console.ReadLine());
            average = (exam1 + exam2 + exam3) / 3;

            if (average >= 50)
            {
                Console.WriteLine($"Average is {average} : Class Passed");
            }
            else 
            {
                Console.WriteLine($"Average is {average} : Class Failed");
            }
           
            */

            // 11 Outputting bigger number from between two numbers

            /*
            int num7 , num8;
            Console.WriteLine("Num 1 : ");
            num7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Num 2 : ");
            num8 = Convert.ToInt32(Console.ReadLine());

            


            if (num7 > num8)
            {
                Console.WriteLine(num7);
                
            }
            else   
            {
                Console.WriteLine(num8);
                
            }
            */

            // 12 Check if input number is even or odd

            /*
            int num9;
            Console.WriteLine("Number : "); 
            num9 = Convert.ToInt32(Console.ReadLine());

            if (num9%2 == 0 )
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            */


            // 13 Check if input number is positive or negative

            /*
            int num10;
            Console.WriteLine("Number : ");
            num10 = Convert.ToInt32(Console.ReadLine());

            if (num10 >= 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
            */


            // 14 

            /*
            int num11;
            Console.WriteLine("Number : ");
            num11 = Convert.ToInt32(Console.ReadLine());

            if (num11 % 4 == 0 && num11 % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 4 and 7");
            }
            else
            {
                Console.WriteLine("The number is not divisible by 4 and 7");
            }
            */

            // 15 Check if the number is between 0 and 100

            /*
            int num12;
            Console.WriteLine("Number : ");
            num12 = Convert.ToInt32(Console.ReadLine());

            if (num12>0 && num12<100 )
            {
                Console.WriteLine("The number is between 0 and 100");
            }
            else
            {
                Console.WriteLine("The number is not between 0 and 100");
            }
            */


            // 16  In case the 3 resistor values entered are in series or parallel, it is taken from the user and calculates the equivalent resistance.

            /*
            static void Main(string[] args)
            {
                double r1, r2, r3, rt;
                int secim;
                Console.Write("R1 :");
                r1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("R2 :");
                r2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("R3 :");
                r3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("**************************");
                Console.WriteLine("1- Serial"); 

                Console.WriteLine("2- Parallel");
                Console.Write("Make your choice : ");

                secim = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("**************************");
                if (secim == 1)
                {
                    rt = r1 + r2 + r3;
                }
                else if (secim == 2)
                {
                    rt = 1 / ((1 / r1) + (1 / r2) + (1 / r3));
                }
                else
                {
                    rt = -1;
                    Console.WriteLine("Wrong choice.");
                }

                Console.WriteLine("Equivalent Resistance : {0} Ohm", rt);
                Console.ReadKey();

            }
            */

            // 17 Write "Hello world" 10 times
            /*
            int i = 0; 
            while (i<10)
            {
                Console.WriteLine("Hello World");
                i++;    
            }
            */


            // 18 Write the inputted message 10 times
            /*
            string msg;
            Console.Write("Write your message : ");
            msg = Console.ReadLine();
            int i = 0;
            while (i<10)
            {
                Console.WriteLine(msg);
                i++;
            }
            */

            // 19 Write the inputted message and by the times of user choice.

            /*
            string msg1;
            int amount;
            Console.Write("Write your message : ");
            msg1 = Console.ReadLine();
            Console.Write("Amount : ");
            amount = Convert.ToInt32(Console.ReadLine());

            int x = 0;
            int a = amount;
            while (x < a)
            {
                Console.WriteLine(msg1);
                x++;
            }
            */


            // 21 Input 10 numbers and find which of them are lower than 50.

            /*
            int number;
            int piece = 0; 
            for (int l = 1; l < 11; l++)
            {
                Console.Write(l+"."+"Number : ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number<50)
                {
                    piece++;
                }
            }
                Console.WriteLine("Numbers that lower than 50 : " + piece);
            */

            // 22 Input 5 numbers and find which of them are greater than 50.
            /*
            int number2;
            int piece2 = 0;
            for (int u = 1; u < 6; u++)
            {
                Console.Write(u+"." + "Number : ");
                number2 = Convert.ToInt32(Console.ReadLine());
                if (number2>50)
                {
                    piece2++;
                }
            
            }
        Console.WriteLine("Numbers that greater than 50 : " + piece2);
        
        }   
            */


            // 23 Finding odd and even numbers from randomly generated numbers and saving them in a list.

            /*
            int numbers, odd_numbers = 0, even_numbers = 0 ;
            
            Random rnd = new Random();
            List<int> A = new List<int>();
            List<int> B = new List<int>();
            
            for (int i = 0; i < 10; i++)
            {
                numbers = rnd.Next(1,100);
                if (numbers%2 == 0 )
                {
                    even_numbers++;
                    A.Add(numbers);
                    Console.WriteLine(numbers);
                }
                else
                {
                    odd_numbers++;
                    B.Add(numbers);
                    Console.WriteLine(numbers);
                }
              
            }
            Console.WriteLine("Odd Numbers: " + string.Join(',', B));
            Console.WriteLine("Even Numbers: " + string.Join(',', A));
            */



            // 24 Generate 10 random numbers and output average of the numbers that greater than 50

            /*
            int numbers; 
            int sum = 0;
            int s = 0;
            Random rnd = new Random();
            

            for (int i = 0; i < 10; i++)
            {
                numbers = rnd.Next(1,100);
                Console.WriteLine(numbers);

                if (numbers > 50)
                {
                    sum += numbers;
                    s++;
                }

            }
            Console.WriteLine("Sum of numbers that greater than 50 : " + sum/s);
            */

            // 25 Take 10 numbers from user and output of the sum of numbers.
            /*
            int number;
            int sum = 0;
            for (int i = 1; i < 11; i++)
            {
                Console.Write(i + "." + " Number : ");
                number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
            */


            // 26
            /*
            int start, finish, increase;

            Console.Write("Starting number : ");
            start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Finishing number : ");
            finish = Convert.ToInt32(Console.ReadLine());

            Console.Write("Increase rate : ");
            increase = Convert.ToInt32(Console.ReadLine());

            for (int i = start; i <= finish; i += increase)
            {
                Console.WriteLine(i);
            }
            */


            // 27 Defining array and console output
            /*
            int[] a = new int[5] { 25, 45, 66, 88, 99 };

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            */

            // 28 Finding the prime numbers from between 1-1000000
            /*
            int check;
            int counter;
            for (int i = 2; i < 1000000; i++)
            {
                check = 0;
                for (int j = 2; j <= i/2; j++)
                {
                    if (i%j == 0)
                    {
                        check++;
                        break;
                    }
                }

                if (check == 0)
                {
                    Console.Write(i + "-");

                }


            }
            */

            // 29 Checking if the input from user is primal number.
            /*
            {
                int check = 0;
                Console.Write("Input a number : ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 1 || number == 0)
                {
                    Console.WriteLine("Number is not primal number");

                }
                else
                {
                    for (int i = 2; i < number / 2; i++)
                    {
                        if (number % i == 0) 
                        {
                            check++;
                            break; 
                        }


                    }

                    if (check != 0)
                    {
                        Console.WriteLine("Number is not primal number");
                    }

                    else
                    {
                        Console.WriteLine("Number is primal number");
                    }

                }


                
            }
            */

            /*
            // 30 Age calculation 
            int date; 
            Console.Write("Enter your year of birth : ");
            date = Convert.ToInt32(Console.ReadLine());

            var CurrentYear = DateTime.Now.Year;
            var age = CurrentYear - date ;
            Console.WriteLine(age);
            */

            // 31 Modulus ; can input number be divided to 3 and 5
            /*
            int number;
            Console.Write("Input a number : ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Number can be divided to 3 and 5");
            }
            else
            {
                Console.WriteLine("Number cannot be divided to 3 and 5");
            }
            */

            // 32 Input a sentence and output characters number of the sentence

            /*
            string sentence;
            Console.Write("Input a sentence : ");
            sentence = Console.ReadLine();

            Console.WriteLine(sentence.Length);
            */

            // 33 Vowel of a sentence (LINQ/lambda)

            /*
            Console.Write("Input a sentence : ");
            
            string sentence = Console.ReadLine();
            int vowelCount = sentence.Count(c => "aeiou".Contains(Char.ToLower(c)));
            Console.WriteLine(vowelCount);
            */

            // 33 Vowel of a sentence
            /*
            Console.Write("Input a sentence : ");
            string sentence = Console.ReadLine();
            string vowels = "aeiou";
            
            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.IndexOf(sentence[i]) >= 0)
                {
                    Console.WriteLine(sentence[i]);
                }
            }
            */

            /*
            // 34 Body Mass Index Calculator
            double height, weight , index =0 ;
            Console.Write("Input height(eg 1,50) : ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input weight : ");
            weight = Convert.ToDouble(Console.ReadLine());
            index = weight / (height * height);

            if (index < 18)
            {
                Console.WriteLine("Skinny");
            }
            else if (index >= 18 && index < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (index >= 25 && index < 30)
            {
                Console.WriteLine("Fat");
            }
            else if (index >= 30 && index < 35)
            {
                Console.WriteLine("Obese");
            }
            else
            {
                Console.WriteLine("Very Obese");
            }
            */

            // 35 Checking phone number 

            /*
            Console.Write("Enter a phone number : ");
            bool isValid = new Regex(@"^(0(\d{3})-(\d{3})-(\d{2})-(\d{2}))$").IsMatch(Console.ReadLine());
            Console.WriteLine(isValid);
            */

            // 36 Doing divide calculation without using divide operator

            /*
            int number1 , number2 , result ;
            Console.Write("Input number1 :");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input number2 :");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("dividend:{0}, divisor:{1}", number1, number2);
            if (number1 == 0)
                result = 0;
            if (number2 == 0)
                result = int.MaxValue;

            bool negResult = false;

            
            if (number1 < 0)
            {
                number1 = -number1;
                if (number2 < 0)
                    number2 = -number2;
                else
                    negResult = true;
            }
            else if (number2 < 0)
            {
                number2 = -number2;
                negResult = true;
            }

            
            
            int quotient = 0;
            while (number1 >= number2)
            {
                number1 = number1 - number2;
                quotient++;
            }

            
            if (negResult)
                quotient = -quotient;
            result = quotient;

            Console.WriteLine("Quotient is {0}.", result);

            Console.ReadLine();
            */

            // 37 Square pyramidal number

            /*
            int sum = 0;
            Console.Write("N : ");
            int n = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                sum = 0;
                
                for (int j = 1; j <= i; j++)
                {
                    sum += j * j;
                    Console.Write(j + "^2");
                    if (j != 0)
                    {
                        Console.Write(" + ");
                    }
                    else
                    {
                        Console.Write(" = ");
                    } 
                }
                Console.WriteLine(sum);
                Console.WriteLine();
            }
        }   */


            // 38 Making a table with ConsoleTable

            /*


            var table = new ConsoleTable("ID" , "Name" , "Country" , "Gender");
            table.AddRow("1" , "Gardner Rodriquez" , "Philippines" , "Male");
            table.AddRow("2", "Dale Law", "Venezuela", "Male");
            table.AddRow("3", "Peter Kirk", "Canada", "Male");
            table.AddRow("4", "Sally Daves", "Hungary", "Female");
            table.AddRow("5", "Maia Todd", "Switzerland", "Female");

            table.Write();
    
            */

            // 39 Endless loop with for
            /*
            int x = 0;
            for (;;)
            {
                x = x + 10;
                Console.WriteLine(x);
            }
            */

            // 40 Printing the Entered Text on the Screen Letter by Letter
            /*
            string sentence;
            Console.Write("Input a sentence or a word : ");
            sentence = Console.ReadLine();

            for (int i = 0; i < sentence.Length; i++)
            {
                Console.WriteLine(sentence[i]);
            }
            */


            // 41 Checking inputted 10 numbers if it is odd or even
            /*
            int[] number = new int[10];
            int i;
            for ( i = 0; i < 10; i++)
            {
                Console.Write("Input a number : ");
                number[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Even numbers");
            Console.WriteLine("-----------");
            for (i = 0; i <= 9; i++)
            {
                if (number[i] % 2 == 0)
                {
                    Console.WriteLine(number[i]);
                }
            }

            Console.WriteLine("Odd numbers");
            Console.WriteLine("-----------");
            for (i = 0; i <= 9; i++)
            {
                if (number[i] % 2 == 1)
                {
                    Console.WriteLine(number[i]);
                }
            }
            */

            // 42 Checking for even and odd 
            /*
            int number;
            Console.Write("Input a number : ");    
            number = Convert.ToInt32(Console.ReadLine());

            if (number %2 == 0)
            {
                Console.Write($"{number} is even");
            }
            else
            {
                Console.Write($"{number} is odd");
            }
            */

            // 43 Generate random numbers and letters (Captcha)
            /*
            Random random = new Random();
            
            string letters = "0123456789qwertyuıopguasdfghjklsizxcvbnmcQWERTYUIOPGUASDFGHJKLSIZXCVBNM";
            var generate = "";
            
            
            for (var j = 0; j < 5; j++)
            {
                    generate += letters[random.Next(letters.Length)];
            }

            Console.WriteLine(generate);
            */

            //44 Display All the Prime Numbers Between 1 to 100
            /*
            bool isPrime = true;
            Console.WriteLine("Prime Numbers : ");
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;

            }

            // another way to do it

            int i, j;

            for (i = 2; i < 100; i++)
            {
                for (j = 2; j <= (i / j); j++)
                    if ((i % j) == 0) break; 
                if (j > (i / j)) Console.WriteLine("{0} is prime", i);
            }

            */

            // 45 Making a Calculator
            /*
            int result , number1 , number2 ; string symbol;            
            Console.Write("Enter first number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter symbol(/,*,-,+) : "  );
            symbol = Console.ReadLine();

            switch (symbol)
            {
                case "+":
                    result = number1 + number2;
                    Console.WriteLine("Addition:" + result);
                    break;
                case "-" :
                    result = number1 - number2;
                    Console.WriteLine("Subtraction:" + result);
                    break ;
                case "*" :
                    result = number1 * number2;
                    Console.WriteLine("Multiplication:" + result);
                    break;
                case "/" :
                    result = number1 / number2;
                    Console.WriteLine("Division:" + result);
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;

            }
            */

            // 46 Finding the Sum of the Digits of the Entered Number
            /*
            int number, result = 0;
            Console.Write("Enter a number : ");
            number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                result += (number % 10); 
                number = number / 10;

            }
            Console.WriteLine(result);
            */

            // 47 Sorting the array list
            /*
            int amount;

            Console.Write("Enter data amount : ");
            amount = Convert.ToInt32(Console.ReadLine());



            string[] list = new string[amount];
            string country;
            for (int i = 0; i < amount; i++)
            {
                Console.Write(i + 1 + "." + "Country name : ");
                country = Console.ReadLine();
                list[i] = country;
            }

            Console.WriteLine("Untouched list");
            Console.WriteLine("---------------------");
                
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            Array.Sort(list);
            Console.WriteLine("Sorted List");
            Console.WriteLine("---------------------");

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            Array.Reverse(list);
            Console.WriteLine("Reserved List");
            Console.WriteLine("---------------------");

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            */

            // 48 the multiplication table

            /*
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{i}*{j}" + "=" + $"{(i * j)}" + "\t");
                    
                }

                Console.WriteLine();
            }
            */

            // 49 Calculating Sum and Average in Array with (n) Elements

            /*
            double sum = 0 , average = 0;
            Console.Write("State upper limit for the array : ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] array = new double[n];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{i+1}.Number : " );
                array[i] = Convert.ToDouble(Console.ReadLine());
                sum += array[i];
            }
            average = sum/ array.Length;
            Console.WriteLine("Sum : " + sum);
            Console.WriteLine("Average : " + average);
            */

            // 50 Finding the Number of Words in the Entered Sentence

            /*
            string sentence;
            Console.Write("Your sentence : ");
            sentence = Console.ReadLine();
            string[] words = sentence.Split();
            Console.WriteLine("Word count : " + words.Length);
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            */

            // 51 Sum with for loop

            /*
            int number, sum = 0;
            for (int i = 1; i < 5; i++)
            {
                Console.Write(i + "." + "Number : ");
                number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("Sum :" + sum);
            */

            // 52 Listing Numbers that Divided by 3 and 7 between 1 and "n" 

            /*
            Console.Write(" Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i%3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            // 53 Square a Number

            /*
            Console.Write(" Number  : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = number * number;
            Console.WriteLine($"Square of {number} is : " + result);

            Console.ReadKey();
            */

            // 54 Swaping 2 number without third variable.

            /*
            Console.Write("First number : ");
            int n1 = int.Parse(Console.ReadLine()); 
            Console.Write("Second number : ");
            int n2 = int.Parse(Console.ReadLine()); 

            Console.WriteLine($"Numbers before swap : {n1} , {n2} ");

            n1 = n1 + n2; 
            n2 = n1 - n2; 
            n1 = n1 - n2;  

            Console.WriteLine($"Numbers after swap :  ");
            Console.WriteLine("First number : " + n1);
            Console.WriteLine("Second number : " + n2);
            */

            // 55 Tax calculation for vehicles

            double amount = 0;
            int choice1, choice2, choice3;
            Console.WriteLine("Type of Vehicle : ");
            Console.WriteLine("================");
            Console.WriteLine("(1) - Normal");
            Console.WriteLine("(2) - Commercial");
            Console.Write("Pick your choice (1)-(2) : ");
            choice1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Age of the vehicle : ");
            Console.WriteLine("================");
            Console.WriteLine("(1) - 1-3 Age");
            Console.WriteLine("(2) - 4-7 Age");
            Console.WriteLine("(3) - 7 Age or more");
            Console.Write("Pick your choice (1)-(2)-(3) : ");
            choice2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Motor Hacmi : ");
            Console.WriteLine("================");
            Console.WriteLine("(1) - 0-1300");
            Console.WriteLine("(2) - 1300-1600");
            Console.WriteLine("(3) - 1600-2000");
            Console.WriteLine("(4) - 2000 Üzeri");
            Console.Write("Pick your choice (1)-(2)-(3) : ");
            choice3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (choice1 == 1)
            {
                amount = 100;
            }
            else if (choice1 == 2)
            {
                amount = 150;
            }
            else
            {
                Console.WriteLine("Wrong choice.");
                amount = 0;
            }
            
            if (choice2 == 1)
            {
                amount = amount * 1.75;
            }
            else if (choice2 == 2)
            {
                amount = amount * 1.5;
            }
            else if (choice2 == 3)
            {
                amount = amount * 1.25;
            }
            else
            {
                Console.WriteLine("Wrong choice.");
                amount = 0;
            }
            
            if (choice3 == 1)
            {
                amount *= 2;
            }
            else if (choice3 == 2)
            {
                amount *= 3;
            }
            else if (choice3 == 3)
            {
                amount *= 4;
            }
            else if (choice3 == 4)
            {
                amount *= 5;
            }
            else
            {
                Console.WriteLine("Wrong choice.");
                amount = 0;
            }

            Console.WriteLine("===============================");
            Console.WriteLine("Amount to be paid : {0}", amount);
            Console.ReadKey();

        }
    }
}

