using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway600PM
{
    public static class StaticClass //total 1 object
    {
        //every memebers inside it will be static
        static StaticClass()
        {

        }

        static int i = 10;
        public static int j { get; set; }
        static void Test()
        {

        }
    }

    public class NonStaticClass //number of objects
    {
        public int i = 10;
        public static int j = 20; //shared across all the objects

        public void FunctionOne()
        {
            i++;
            j++;
            Console.WriteLine("Value of NonStatic Member i = " + i);
            Console.WriteLine("Value of Static Member j = " + j);
        }

        public static void StaticFunction()
        {
            
            j++;
        }
    }



    public class PassBy
    {
        public static void AddByValue(int x, int y)
        {
            x++;
            y++;
            Console.WriteLine("Sum of x and y are " + (x + y));
        }

        public static void AddByReference(ref int x, int y)
        {
            x++;
            y++;
            Console.WriteLine("Sum of x and y are " + (x + y));
        }


        public static void AddByOut(in int x, in int y, out int z)
        {
            
            z = x + y;
            Console.WriteLine("Sum of x and y are " + (x + y));

        }
    }
}
