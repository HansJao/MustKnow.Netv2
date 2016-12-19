using System;

namespace ClassLibrary.Polymorphism
{
    public class JpgFile : ImageFile
    {
        public override void Open()
        {
            Console.WriteLine("Open the JPG file.");
        }
    }
}
