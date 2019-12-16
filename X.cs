using System;
using System.Collections.Generic;
using System.Text;

namespace seald_class_and_member
{
    public class X
    {
        public virtual void F()
        {
            Console.WriteLine("X.F");
        }
        public virtual void F2()
        {
            Console.WriteLine("X.F2");
        }
    }
     public class Y : X
    {
        sealed public override void F()
        {
            Console.WriteLine("Y.F");
        }
        public override void F2()
        {
            Console.WriteLine("Y.F2");
        }

    }
    class Z : Y
    {
        /*
        public override void F()
        {
           
        }
        */
        public override void F2()
        {
            Console.WriteLine("Z.F2");
        }
    }
}
