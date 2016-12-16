using ClassLibrary.Adapter;
using System;
using Bird = ClassLibrary.Inheritance.Bird;

namespace MustKnow.NetV2
{
    class Program
    {
        static void Main(string[] args)
        {
            BirdAdapter birdAdapter = new BirdAdapter(new Chicken());
            birdAdapter.ToTweet();
            birdAdapter.ShowType();

            BirdAdapter ba = new BirdAdapter(new ClassLibrary.Adapter.Eagle());
            ba.ShowType();
            ba.ToTweet();

            Console.WriteLine("=========================================");

            #region Inheritance

            Bird bird = new Bird();
            bird.ShowType();
            Bird bird2 = new ClassLibrary.Inheritance.Eagle();
            bird2.ShowType();//尋找與創建欄位最近的作存取
            Console.WriteLine(bird2.type);
            bird2.ShowType2();
            ClassLibrary.Inheritance.Eagle eagle = new ClassLibrary.Inheritance.Eagle();
            eagle.ShowType();
            eagle.ShowType2();

            #endregion

            Console.ReadLine();
        }
    }
}
