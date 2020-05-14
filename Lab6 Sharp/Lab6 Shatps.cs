using System;

namespace Lab6_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Calculate c1 = new Calculate(a: 1, b: 2, c: 3, d: 4); //right values
                Calculate c2 = new Calculate(a: 0, b: 2, c: 3, d: 4); //a==0
                //Calculate c3 = new Calculate(a: 1, b: 0, c: 3, d: 4); //b=0
                //Calculate c4 = new Calculate(a: 1, b: -2, c: 3, d: 4); //a*b<0
                //Calculate c5 = new Calculate(a: 1, b: 2, c: 3, d: 6); 
                Console.WriteLine(c1.Result());


            }
            catch (DivideByZeroException exeption)
            {
                
                Console.WriteLine(exeption.Message);
                
            }
            catch (ArithmeticException exeption)
            {
                Console.WriteLine(exeption.Message);
                
            }
           
          

        }
    }
}
