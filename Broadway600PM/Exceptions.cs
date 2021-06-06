using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway600PM
{
    public class Exceptions
    {
        public Exceptions()
        {
            ex = new ExTest();
        }
        //object reference not found

        public ExTest ex { get; set; }
        public void FunctionOne(int max)
        {
            ex = new ExTest();
                ex.I = 10;
                Console.WriteLine(ex.I);
            int[] i = new int[max];
            i[5] = 20;
           
        }
    }

    public class ExTest
    {
        public int I { get; set; }

        public void SetValue(int i)
        {
            if (i>100)
            {
                throw new Exception("greater than 100 is invalid");
            }
        }
    }

    public class Subject
    {
        public string SubjectName { get; set; }
        public readonly double FullMarks = 100;
        public readonly double PassMarks = 32;
        public readonly double MinMarks = 0;

        private double marksObtained = 0;
        public double MarksObtained
        {
            get
            {
                return marksObtained;
            }
        }
        public void SetMarks(double marks)
        {
            if (marks > FullMarks)
            {
                throw new GreaterThanFullMarksException("Marks cannot be greater than full marks");
            }
            if (marks<MinMarks)
            {
                throw new SmallerThanMinMarksException("Marks cannot be less than minimum marks");
            }

            marksObtained = marks;
        }
    }


    [Serializable]
    public class GreaterThanFullMarksException : Exception
    {
        public GreaterThanFullMarksException() { }
        public GreaterThanFullMarksException(string message) : base(message) { }
        public GreaterThanFullMarksException(string message, Exception inner) : base(message, inner) { }
        protected GreaterThanFullMarksException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }


    [Serializable]
    public class SmallerThanMinMarksException : Exception
    {
        public SmallerThanMinMarksException() { }
        public SmallerThanMinMarksException(string message) : base(message) { }
        public SmallerThanMinMarksException(string message, Exception inner) : base(message, inner) { }
        protected SmallerThanMinMarksException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
