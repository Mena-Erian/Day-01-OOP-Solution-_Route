using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Class1 : TypeD
    {
        public Class1()
        {

            _protected = 9;//private
            _internal_protected = 8;//private

        }
        internal int x;
    }
    public class Class2
    {
        public Class2()
        {

            Class1 class1 = new Class1();
            //class1.
        }

    }
}
