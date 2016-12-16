using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary.Inheritance
{
    public abstract class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal Eat");
        }
        public abstract void ShowType();

    }

    public class Bird : Animal
    {
        public string type = "Bird";
        string Color { get; set; }
        public override void ShowType()
        {
            Console.WriteLine("Type is {0}",type);
        }
        public  void ShowType2()
        {
            Console.WriteLine("Type is {0}", type);
        }
    }

    public class Eagle :Bird
    {
        private string type = "Eagle";

        public override void ShowType()
        {
            Console.WriteLine("Type is {0}",type);
        }

        public  void ShowType2()
        {
            Console.WriteLine("Type is {0}", type);
        }

        public void FlyingEagle()
        {

        }

    }
}
