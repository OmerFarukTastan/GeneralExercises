using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralExercises
{
    public class Switch
    {     
        enum Calculation
        {
            addition, // "+"
            subtraction, // "-"   
            division, // "/"
            multiplication // "*"
        }
        static void Main(string args)

            
        {
                int A = 100;    int B = 200;
            Calculation Choice = (Calculation)0;
            switch (Choice)
            {
                case Calculation.addition:
                    Console.WriteLine($"{A} + {B} = {A+B}");
                    break;
                case Calculation.subtraction:
                    break;
                case Calculation.division:
                    break;
                case Calculation.multiplication:
                    break;
                default:
                    break;
            }
            {






            }
        }
    }
}
