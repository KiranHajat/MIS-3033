using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inclassparticipation
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4;
             num1 = 51;
             num2 = 3;
             num3 = 10;
            num4 = 89;

            double result = Add(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {result}");
            

             result = Subtract(num3, num4);
            Console.WriteLine($"{num3} - {num4} = {result}");

            double[] allTheNumbers = new double[5];
                allTheNumbers[0] = 1;
            allTheNumbers[1] = 4;
            allTheNumbers[2] = 5;
            allTheNumbers[3] = 10;
            allTheNumbers[4] = 20;

            result = Add(allTheNumbers);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns>the sum of val1 and val2</returns>
        static double Add(double val1, double val2)  //creating a method //give me a double, give me two double and i will give you a double in retrun, use key word retrun
        {
            var sum = val1 + val2;
            return sum;  // retrun is important, if having a conditon like if that have more retruns
        }
       static double Add(double[] values) //give me array of doubles and i will give you double, since we dont know how many values are there, so do a loop
        {

            double sum = 0;
            int counter = 0;
            //while
            while (counter > values.Length)
            {
                sum += values[counter];
                counter++;
            }

            //for  //IT has counter ++, so do this when you do iterations. 
            for ( counter = 0; counter < values.Length; counter++)
            {
                //sum += values[counter];
                var item = values[counter];
                sum += item;
               
            }
            //foreach
            sum = 0;
            foreach (var item in values)
            {
                sum += item;
            }
            return sum;

        }
        static double Subtract(double val1, double val2)
        {
            return val1-val2;
        }
    }
}
