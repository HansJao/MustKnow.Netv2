using System;

namespace ClassLibrary.Adapter
{
    public abstract class Bird
    {
        private string type = "Bird";

        public abstract void ShowType();

    }

    public class Chicken : Bird
    {
        private string type = "Chicken";

        public override void ShowType()
        {
            Console.WriteLine("This is {0}", type);
        }
    }

    public class Eagle : Bird
    {
        private string type = "Eagle";

        public override void ShowType()
        {
            Console.WriteLine("This is {0}", type);
        }

    }

    public interface ITweet
    {
        void ToTweet();
    }

    public class BirdAdapter :ITweet
    {
        private Bird _bird;

        public BirdAdapter(Bird bird)
        {
            _bird = bird;
        }

        public void ShowType()
        {
            _bird.ShowType();
        }
        public void ToTweet()
        {
            Console.WriteLine("{0} Tweet");
        }
    }
}
