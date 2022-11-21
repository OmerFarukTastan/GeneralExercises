using System.Security.Cryptography.X509Certificates;

namespace Exercise 
{

    public class program
        {

    
            static void Main(string args)
            {
        
        
                    int s = 5;
                    string a = "School"; 
                    Console.WriteLine(s + a); 
                    Console.WriteLine(a);
                    Console.WriteLine("Hey");

                    Console.WriteLine("**************************************************");

                    int A = 10;  int B = 20; int C = 10;
                    Console.WriteLine(A + B);
                    Console.WriteLine(A - B);
                    Console.WriteLine(A * B);
                    Console.WriteLine(A / B);
                    Console.WriteLine(A % B);

            Console.WriteLine("**************************************************");
            
            
            
            if (A > B)
            {
                Console.WriteLine("A büyük");
            }
            else if (A == B && B == A ) 
            {
                Console.WriteLine("Eşit");
            }
            else if (A == B || C==A)
            {
                Console.WriteLine("Eşit2");
            }         

            else
            {
                Console.WriteLine("B yüyük");

            }
            
            
            Console.WriteLine("**************************************************");

            int z = 100;
            int b = 0;         
            
            
            while (b<z)
            {
                Console.WriteLine(b + z);
                
                b++;
                switch (b)
                {
                    case 0:
                        z = 55;
                        Console.WriteLine("Z 55 oldu.");
                        break;
                    case 1:
                        b = 97;
                        Console.WriteLine("b 97 oldu");
                        break;

                    default:
                        Console.WriteLine("Bom");
                        break;
                }
            }
            Console.WriteLine("**************************************************");
            switch (b)
            {
                case 0:
                    z = 55;
                Console.WriteLine(z);
                    break;
                case 1:
                    b = 97;
                    Console.WriteLine(b);
                    break;

                default:
                    Console.WriteLine("Bom");
                    break;
            }
            Console.WriteLine("**************************************************");


                    
                
            
                int g = 50; int k = 150;
            {
                    switch (A)
            {
                case 0:
                    Console.WriteLine($"{g} + {k} = {g+k} " );
                    break;


                default:
                    break;
            }
            
            }

            int H = 5;
            H += 10;
            Console.WriteLine(H);






        }
    

        }   


}


class switch_case
{
    enum Calculation
    {
        addition, // "+"
        subtraction, // "-"   
        division, // "/"
        multiplication // "*"
    }
    static void Main()
    {
        int A = 100; int B = 200;
        
        Calculation Choice = (Calculation)1;
        switch (Choice)
        {
            case Calculation.addition:
                Console.WriteLine($"{A} + {B} = {A + B}");
                break;
            case Calculation.subtraction:
                Console.WriteLine($"{A} - {B} = {A - B}");
                break;
            case Calculation.division:
                Console.WriteLine($"{A} / {B} = {A / B}");
                break;
            case Calculation.multiplication:
                Console.WriteLine($"{A} * {B} = {A * B}");
                break;
            default:
                Console.WriteLine("geçersiz");
                break;
        }
    }
}       
