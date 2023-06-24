using System;
using System.Runtime.CompilerServices;

namespace taklif
{
    class miad
    {
        public static void Main()
        {


            Console.Write("nomreh mian term ra vared kn : ");
            double a = Convert.ToInt32(Console.ReadLine());


            Console.Write("nomreh payan term ra vared kn: ");
            double b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("nomreh nahaei = {0}", calc(a,b));


            if (calc(a, b) >= 10)
            {
                Console.WriteLine("ghabool shdi :)");
            }
            else
            {
                Console.WriteLine("oftadi :( ");
               
            }
        }

        private static double calc(double a, double b)
        {
            double result = 0.35 * a + 0.65 * b;
            return result;
            
        }
        
    }
}
