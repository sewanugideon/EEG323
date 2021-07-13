using System;

namespace csharp2
{
    class Program2
    {
        static void Main(string[] args)
        {
         while(true)
            {
          
                
             //float a,b,c,d,e,f;

                Console.WriteLine("Enter A:");
                float a = Convert.ToSingle( Console.ReadLine() );

                Console.WriteLine("Enter B:");
                float b = Convert.ToSingle( Console.ReadLine() );

                Console.WriteLine("Enter C:");
                float c = Convert.ToSingle( Console.ReadLine() );

                Console.WriteLine("Enter D:");
                float d = Convert.ToSingle( Console.ReadLine() );

                Console.WriteLine("Enter E:");
                float e = Convert.ToSingle( Console.ReadLine() );

                Console.WriteLine("Enter F:");
                float f = Convert.ToSingle( Console.ReadLine() );

                float determinant = (a*d) - (b*c);
                float changeInX   = (e*d) - (b*f);
                float changeInY   = (a*f) - (e*c);

                if(determinant == 0)
                {
                    Console.WriteLine("The equation has no solution.");
                    continue;
                }
                else
                {
                    float x = changeInX/determinant;
                    float y = changeInY/determinant;

                    Console.WriteLine("The value Of \n X is {0} \n Y is {1} ", x, y);
                }
                break;
            }
        }
    }
}
