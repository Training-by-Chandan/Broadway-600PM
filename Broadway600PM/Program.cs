using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway600PM
{
    class Program
    {
        static void Main(string[] args)
        {
            bool looping = true;
            if (args.Length!=0)
            {
                if (args.Contains("developer"))
                {
                    //enable some feature
                    Console.WriteLine("Developer Mode enabled");
                }

                if (args.Contains("loopingdisabled"))
                {
                    looping = false;
                }
            }
            string result = "n";
            do
            {

                //InitialCode();

                //MathFunctions();

                //StringFunctions();

                //SwitchCaseExample();

                //LoopingExamples();

                //ArrayExample();

                //ClassAndObjectExample();

                //StudentClassExample();

                //InheritanceExample();

                //InterfaceExample();


                //AbstractExample();

                //CollectionsExample();

                //CustomStackImplementation();

                //StaticAndNonStaticExample();

                //PassByExample();
                ExceptionExamples();

                if (looping)
                {
                    Console.WriteLine("Do you want to continue more? (y/n)");
                    result = Console.ReadLine();
                }
            }
            while (result.ToLower()[0] == 'y' && looping);
            Console.ReadLine();
            
        }

        static void ExceptionNew()
        {
            Exceptions ex = new Exceptions();
            //ex.FunctionOne(2);
            ex.ex.SetValue(101);
        }

        static void ExceptionExamples()
        {
            try
            {

                Subject s1 = new Subject();
                s1.SetMarks(10);
                s1.SetMarks(1);
            }
            catch(GreaterThanFullMarksException ex)
            {
                Console.WriteLine("Not valid");
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I am from finally block");
            }
            
        }


        static void PassByExample()
        {
            int a = 10;
            int b = 20;
            PassBy.AddByValue(a, b); //Add(10,20)

            Console.WriteLine($"a=>{a} b=>{b}");
            PassBy.AddByReference(ref a, b);
            Console.WriteLine($"a=>{a} b=>{b}");


            int OutVal = 0;
            PassBy.AddByOut(a, b, out OutVal);
            Console.WriteLine($"OutVal = {OutVal}");
        }

        static void StaticAndNonStaticExample()
        {
            NonStaticClass c1 = new NonStaticClass();
           
            c1.FunctionOne();
            NonStaticClass c2 = new NonStaticClass();
            c2.FunctionOne();
            NonStaticClass c3 = new NonStaticClass();
            c3.FunctionOne();
            NonStaticClass c4 = new NonStaticClass();
            c4.FunctionOne();
            
        }

        static void CustomStackImplementation()
        {
            ShapeTemplate<Rectangle> s = new ShapeTemplate<Rectangle>();
            ShapeTemplate<string> s1 = new ShapeTemplate<string>();

            Test t = new Test();
            //t.TemplatedFunction<string, int>("",2);
            //t.TemplatedFunction<int,double>(1,1.2d);

            CustomStackTemplate<string> c2 = new CustomStackTemplate<string>();
            c2.Push("");
            CustomStackTemplate<int> c1 = new CustomStackTemplate<int>(10);
            c1.Push(10);
            c1.Push(6);
            c1.Push(5);
            c1.Push(4);
            c1.Push(2);
            c1.Push(1);
            c1.Peek();
            Console.WriteLine("Initial reading");
            c1.Display();

            c1.Pop();
            c1.Pop();
            c1.Pop();
            c1.Pop();
            c1.Pop();
            c1.Pop();
            Console.WriteLine("After popping");
            c1.Display();
            c1.Push(7);
            Console.WriteLine("After pushing 7");

            c1.Display();
        }

        static void CollectionsExample()
        {
            //List<string> list = new List<string>();
            //list.Add("Abhash");
            //list.Add("Ram");
            //list.Add("Dipendra");
            //list.Add("Dharmendra");
            //list.Add("Saramsh");
            //list.Add("Chandan");
            //list.Add("Kumar");
            //list.Add("Hari");
            //list.Add("Binod");
            //list.Add("Saroj");

            
            List<TestModel> listTest = new List<TestModel>();
            listTest.Add(new TestModel("Abash", "Lalitpur"));
            listTest.Add(new TestModel("Binod", "Baneshwor"));
            listTest.Add(new TestModel("Hari", "Kalanki"));
            listTest.Add(new TestModel("Saramsh", "Dhapakhel"));
            listTest.Add(new TestModel("Dipendra", "Bhaktapur"));
            listTest.Add(new TestModel("Dharmendra", "Damak"));
            listTest.Add(new TestModel("Saroj", "Mahendranagar"));
            listTest.Add(new TestModel("Aakash", "Biratnagar"));
            listTest.Add(new TestModel("Nawanit", "Itahari"));
            listTest.Add(new TestModel("Kumar", "Maharajgunj"));
            listTest.Add(new TestModel("Biraj", "Budhanilkantha"));

            //linq query 
            var len = (from abhash in listTest where abhash.Name.ToUpper().StartsWith("S") orderby abhash.Address 
                   select abhash).ToList();

            //linq lambda expression
            //var len = listTest.Where(p=>p.Name.ToUpper().StartsWith("S") ).OrderBy(abhash => abhash.Address).ToList();

            foreach (var item in len)
            {
                Console.WriteLine(item.Name +" lives in  "+ item.Address);
            }

        }

        static ShapeAbs sAbs;
        static void AbstractExample()
        {
            Console.WriteLine("Using Abstract Classes");
            Console.WriteLine("Press");
            Console.WriteLine("1 for Rectangle");
            Console.WriteLine("2 for square");
          
            var choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    sAbs = new RectangleAbs();
                    break;

                case 2:
                    sAbs = new SquareAbs();
                    break;
               

                default:
                    break;
            }

            sAbs.GetInput();
            sAbs.Perimeter();
            sAbs.Area();
        }


        static IShape s1;
        static IArea a1;
        static IPerimeter p1;

        static IShape[] arrayOfShapes=new IShape[10];
        static void InterfaceExample()
        {
            Console.WriteLine("Press");
            Console.WriteLine("1 for Rectangle");
            Console.WriteLine("2 for square");
            Console.WriteLine("3 for circle");
            var choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    s1 = new Rectangle();
                    break;

                case 2:
                    s1 = new Square();
                    break;
                case 3:
                    s1 = new Circle();
                    break;

                default:
                    break;
            }

            s1.GetInput();
            s1.Perimeter();
            s1.Area();


            //
            Rectangle r = new Rectangle();
            r.Length = 20;
            r.Breadth = 20;
            r.Area();
            r.GetInput();
            r.Perimeter();
            r.Test();

            s1 = r;
            
            s1.GetInput();
            s1.Area();
            s1.Perimeter();


            a1 = r;
            a1.Area();

            p1 = r;
            p1.Perimeter();

            arrayOfShapes[0] = new Rectangle();
            arrayOfShapes[1] = new Square();
            arrayOfShapes[0] = new Rectangle();
            arrayOfShapes[0] = new Circle();
            arrayOfShapes[0] = new Rectangle();
           
        }

        static void InheritanceExample()
        {
            LivingThing l1 = new LivingThing();
            //Animal a1 = new Animal(12);

            LivingThing l2 = new Animal();

            l1.FunctionInheritance();
            l2.FunctionInheritance();

           // Vertibrate v1 = new Vertibrate();


            //Console.WriteLine("l1.publicLivingThing => " + l1.publicLivingThing);
            //Console.WriteLine("a1.publicLivingThing => " + a1.publicLivingThing);
            //Console.WriteLine("a1.publicAnimal => " + a1.publicAnimal);
        }

        static void StudentClassExample()
        {
            Student s1 = new Student();
            Student s2 = new Student();


            //Student Dharmendra = new Student("Dharmendra", 25);
            //Student Abash = new Student("Abhash", 27);
            //Student Dipendra = new Student("Dipendra", 24);


            //Console.WriteLine(s1.Age + " "+ s1.Name +" "+ s1.Weight);
            //s1++;
            //Console.WriteLine(s1.Age + " "+ s1.Name +" "+ s1.Weight);
            //s1--;
            //Console.WriteLine(s1.Age + " "+ s1.Name +" "+ s1.Weight);

           var s = s1 + s2;

            if (s1==s2)
            {
                Console.WriteLine("Are equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }

        }

        static void ClassAndObjectExample()
        {
            Test m1 = new Test();// instansiate
            Test t1 = new Test("Dipendra");
            t1 = new Test("Biraj", 50);
            t1 = new Test("Abhash");


            m1.i = 20; //value set
            var i = m1.i; //get the value 
            var name = m1.Name;
            m1.Name = "Dipendra";

            m1.Name = "";

            var fullname = m1.FullName;

            m1.FirstName = "Biraj";
            m1.LastName = "Pradhan";

            fullname = m1.FullName;

            var ret=m1.FunctionOne( "Biraj1");
            ret=m1.FunctionOne( "Biraj1");
            ret=m1.FunctionOne( "Biraj1");
            ret=m1.FunctionOne( "Biraj1");
            ret=m1.FunctionOne( "Biraj1");
            ret=m1.FunctionOne( "Biraj1");
            ret=m1.FunctionOne( "Biraj1");
            ret=m1.FunctionOne( "Biraj1");
            ret=m1.FunctionOne( "Biraj1");

            Test m2 = new Test();
            m2.i = 30;
        }

        static void ArrayExample()
        {
            int[] arr = new int[5];
            
            arr[0] = 16;
            arr[1] = 'C'; //implicit casting
            arr[2] = 17;
            arr[3] = 18;
            arr[4] = 15;

            //int[] oldarr = arr;
            //arr = new int[7];
            //int looping = oldarr.Length > arr.Length ? arr.Length : oldarr.Length;
            //for (int i = 0; i < looping; i++)
            //{
            //    arr[i] = oldarr[i];
            //}

            //Array.Reverse(arr);
            int[] newArr = new int[5];
            //newArr[0] = arr[1];
            //newArr[1] = arr[3];

            Array.Copy(arr, newArr, 2); 
            newArr = new int[5];
            Array.Copy(arr, newArr, 5);
            newArr = new int[5]; 
            Array.Copy(arr,2, newArr,1, 2);


            //Array.Resize(ref arr, 2);
            var i = "biraj";
            i = (10).ToString();


            object k = "saramsh";
            k = 10;

            object[] objArr = new object[10];
            objArr[0] = "";
            objArr[1] = 1;


            object arrayobj = objArr;
        }

        static void LoopingExamples()
        {
            string str = "Hello Worlds!";
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("Character => " + str[i] + " Number => " + i);
            }

            foreach (var item in str)
            {
                Console.WriteLine("Character => " + item);
            }
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
            var res = System.Math.Pow(baseNum, powNum);
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
