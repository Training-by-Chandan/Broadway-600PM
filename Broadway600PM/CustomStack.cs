using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway600PM
{
    public class CustomStack
    {
        readonly int MaxSize;
        private int[] container = new int[0];
        private int counter = 0;

        public CustomStack()
        {
            MaxSize = 5;
            container = new int[MaxSize];
        }
        public CustomStack(int maxsize)
        {
            MaxSize = maxsize;
            container = new int[maxsize];
        }

        public void Push(int item)
        {
            if (counter<MaxSize)
            {
                container[counter] = item;
                counter++;
            }
        }

        public void Pop()
        {
            if (counter>0)
            {
                container[counter-1] = 0;
                counter--;
            }
        }

        public void Display()
        {
            if (counter>0)
            {
                for (int i = counter - 1; i >= 0; i--)
                {
                    Console.WriteLine(container[i]);
                }
            }
        }
        public void Peek()
        {
            if (counter>0)
            {
                Console.WriteLine("Top most item is =" + container[counter-1]);
            }
        }
    }

    public class CustomStackString
    {
        readonly int MaxSize;
        private string[] container = new string[0];
        private int counter = 0;

        public CustomStackString()
        {
            MaxSize = 5;
            container = new string[MaxSize];
        }
        public CustomStackString(int maxsize)
        {
            MaxSize = maxsize;
            container = new string[maxsize];
        }

        public void Push(string item)
        {
            if (counter < MaxSize)
            {
                container[counter] = item;
                counter++;
            }
        }

        public void Pop()
        {
            if (counter > 0)
            {
                
                counter--;
            }
        }

        public void Display()
        {
            if (counter > 0)
            {
                for (int i = counter - 1; i >= 0; i--)
                {
                    Console.WriteLine(container[i]);
                }
            }
        }
        public void Peek()
        {
            if (counter > 0)
            {
                Console.WriteLine("Top most item is =" + container[counter - 1]);
            }
        }
    }

    public class CustomStackTemplate<T>
    {
        readonly int MaxSize;
        private T[] container = new T[0];
        private int counter = 0;

        public CustomStackTemplate()
        {
            MaxSize = 5;
            container = new T[MaxSize];
        }
        public CustomStackTemplate(int maxsize)
        {
            MaxSize = maxsize;
            container = new T[maxsize];
        }

        public void Push(T item)
        {
            if (counter < MaxSize)
            {
                container[counter] = item;
                counter++;
            }
        }

        public void Pop()
        {
            if (counter > 0)
            {
               
                counter--;
            }
        }

        public void Display()
        {
            if (counter > 0)
            {
                for (int i = counter - 1; i >= 0; i--)
                {
                    Console.WriteLine(container[i]);
                }
            }
        }
        public void Peek()
        {
            if (counter > 0)
            {
                Console.WriteLine("Top most item is =" + container[counter - 1]);
            }
        }
    }


    public class ShapeTemplate<T> where T: class
    {

    }
}
