using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB : TypeD
    {
        internal int testInternal;
        public TypeB() // Special Funtion
        {
            TypeA typeA = new TypeA();
            //typeA.X = 10; [Invalid] X is inaccessible due to its protection lever "private".
            typeA.Y = 20; // [Valid]  Y is "internal" The Object is Declared inside the same projet
            typeA.Z = 30; // [Valid]

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.Test()/* = 4*/;
            EmployeeBase employee = new EmployeeBase();
            employee.Test();
            //TypeC typeC = new TypeC();





        }

        public TypeB(int x, int y, int z)
        {
            //H    // not inhereted
            _private_Protected = x; // private
            _protected = y; // private
            _internal_protected = z; // internal
        }

        public void Test()
        {
            TypeD obj = new TypeD();
            //obj.X; not vaild
            //obj.Y; not vaild
            obj._internal_protected = 30; // vaild is internal

        }

    }
    class hamada : TypeD
    {
        public hamada()
        {
            TypeD typeD = new TypeD();  
            
            TypeB typeB = new TypeB();  
            typeB.testInternal = 1;
        }
    }
}
