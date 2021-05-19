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
            //InitialCode();

            //MathFunctions();

            //StringFunctions();

            SwitchCaseExample();



            Console.ReadLine();
            
        }

        static void SwitchCaseExample()
        {
            Console.WriteLine("Enter the number of day");
            var number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    break;
            }

            switch(number)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Weeekdays");
                    break;
                case 1:
                case 7:
                    Console.WriteLine("Weekends");
                    break;

                default:
                    break;
            }

        }

        static void StringFunctions()
        {
            Console.WriteLine("Enter First Name");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter Middle Name");
            var middlename = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            var lastName = Console.ReadLine();
            string fullname = "";
            //var fullname= firstName + " " + middlename + " " + lastName;
            //var fullname1 = string.Concat(firstName, middlename, lastName);
            //var fullname2 = string.Format("{0} {1} {2}", firstName, middlename, lastName);
            //var fullname3 = $"{firstName} {middlename} {lastName}";
            //var replaced = fullname.Replace(" ", "   ");
            //var length = fullname.Length;

            if (string.IsNullOrWhiteSpace(middlename))
                fullname = $"{firstName} {lastName}";
            else
                fullname = $"{firstName} {middlename} {lastName}";
            // (condition)?True statement : false statement;
            
            fullname = string.IsNullOrWhiteSpace(middlename) ? $"{firstName} {lastName}" : $"{firstName} {middlename} {lastName}";

           // StringBuilder sb = new StringBuilder();
           // sb.Append("My name is Abhash.\n");
           // sb.Append("My name is Biraj.\n");
           // sb.Append("My name is Dipendra.\n");
           // sb.Append("My name is Saramsh.\n");
           //sb.Append("My name is Nawanit.\n");
           // string output = sb.ToString();

            var finalstr1 = "My Name is " + fullname;
            Console.WriteLine(finalstr1);



          
            
        }

        static void MathFunctions() 
        {
            Console.WriteLine("Enter the base");
            var baseNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Power");
            var powNum = Convert.ToDouble(Console.ReadLine());
            var res = Math.Pow(baseNum, powNum);
            Console.WriteLine(res);
        }

        static void InitialCode()
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
        }
    }
}
