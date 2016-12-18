using System;

namespace ClassLibrary.Polymorphism
{
    public class WordFile : DocFile
    {
        public override void Open()
        {
            Console.WriteLine("Open the Word file.");
        }
    }
}
