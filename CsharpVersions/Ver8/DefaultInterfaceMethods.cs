using System;
using System.Collections.Generic;
using System.Text;

namespace Ver8.DefaultInterfaceMethods
{

    interface IDefaultInterfaceMethods
    {
        int Compute(int a, int b);

        /// <summary>
        /// Method was added later to this Interface, after several Implementations do exist.
        /// Updating implementing Classes isn't necessary with Default Interface Methods
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int LaterAddedMethod(int a, int b)
        {
            var c = a + b;
            return c;
        }
    }

    public class DefaultInterfaceMethods : IDefaultInterfaceMethods
    {
        public int Compute(int a, int b)
        {
            return a - b;
        }

        public int LaterAddedMethod(int a, int b)
        {
            return 9;
        }
    }

    public class DefaultInterfaceMethods2 : IDefaultInterfaceMethods
    {
        public int Compute(int a, int b)
        {
            return a - b;
        }
    }

    public class UseIt
    {
        void Test(int a, int b)
        {
            IDefaultInterfaceMethods d = new DefaultInterfaceMethods();
            d.Compute(a, b);
            d.LaterAddedMethod(a, b);

            IDefaultInterfaceMethods d2 = new DefaultInterfaceMethods2();
            d2.Compute(a, b);
            d2.LaterAddedMethod(a, b);  // <= Implementation not necessary in class DefaultInterfaceMethods2
        }
    }
}
