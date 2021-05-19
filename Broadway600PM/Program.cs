using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway600PM
{
    class Program
    {
        static void Main()
        {
            //ctrl + k,c for comment
            //ctrl + k, u for uncomment

            // move code up or down alt + up or down key 

            Console.Write("Test");
            Console.WriteLine("Testing");

            Console.Read();
            var t = Console.ReadLine();

            
            //implicit casting
            char c = '1';
            int i = c;
            long l = i;
            float f = l;
            double d = f;

            //explicit casting
            f = (float)d;
            l = (long)f;
            i = (int)l;
            c = (char)i;

            //type conversion class
            long number = Convert.ToInt64("12");
            int numInt = Convert.ToInt32("12");
            string str = number.ToString();

            var res = i + numInt;

            Console.ReadLine();
            
        }
    }
}
