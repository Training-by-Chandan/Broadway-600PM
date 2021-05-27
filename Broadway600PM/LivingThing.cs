using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway600PM
{
    public class LivingThing
    {
        public LivingThing()
        {

        }
        public LivingThing(int privatedata)
        {
            privateLivingThing = privatedata;
        }

        private int privateLivingThing = 10;
        protected int protectedLivingThinbg = 20;
        public int publicLivingThing = 30;

        public virtual void FunctionInheritance()
        {
            Console.WriteLine("I am from Living thing class");
        }
    }

    public class Animal : LivingThing
    {
        public Animal() : base()
        {

        }

        public Animal(int privateData) : base(privateData)
        {

        }
        private int privateAnimal = 10;
        protected int protectedAnimal = 20;
        public int publicAnimal = 30;
        void Function()
        {
           
            protectedLivingThinbg = 0;
            publicLivingThing = 0;

            privateAnimal = 0;
            protectedAnimal = 0;
            publicAnimal = 0;
            
        }

        public override void FunctionInheritance()
        {
            Console.WriteLine("I am from Animal class");
            base.FunctionInheritance();
        }

    }

    public class Plant : LivingThing
    {
        private int privatePlant = 10;
        protected int protectedPlant = 20;
        public int publicPlant = 30;
    }

    public sealed class Vertibrate : Animal
    {
        public Vertibrate() :base()
        {

        }
        private int privateVertibrate = 10;
        protected int protectedVertibrate = 20;
        public int publicVertibrate = 30;
    }

  
}
