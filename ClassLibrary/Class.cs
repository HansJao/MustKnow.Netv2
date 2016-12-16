using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    interface IRemoter
    {

        int Top();
        int Down();
    }

    public class Benq : IRemoter
    {
        int number = 4;
        public int Down()
        {
            return number++;
        }

        public int Top()
        {
            return number--;
        }
    }

    public class Sharp : IRemoter
    {
        int number = 5;
        public int Down()
        {
            return number++;
        }

        public int Top()
        {
            return number--;
        }
    }
    public class Class
    {
        public void TestTv()
        {
            IRemoter TV = new Sharp();
            var nowNumber = TV.Down();
        }
        
    }
}
