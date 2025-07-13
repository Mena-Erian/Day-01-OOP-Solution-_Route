using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    // inheritance & abstraction & Encapsolation
    public class EmployeeBase
    {
        // Private Member Can't Inheritain it


        // Access Scope = 'private', (inheritance Scope = 'protected')
        //                              => it Make access for classes Inherit From it
        //                                      -Make it 'private' => private int Id in thier inheritance
        //                                      -Without 'protected' it Makes the heirs Can't Access it
        private protected int Id;
        private protected string? Name;
        private protected int Age;

        internal protected void Test()
        {

        }

        // Access Scope = , Inheritance Scope = 

        // 'private' =>          Access Scope = 'private', Inheritance Scope = Dosn't inherit it

        // 'private' + 'protected' => Access Scope = 'private', Inheritance Scope = it will be inheret
        //                                                  but it will make it private so you can't
        //                                                  Access this field when you take instance.

        // 'protected' => Access Scope = 'private', Inheritance Scope = 

        protected int Birthday;

    }
    public class FullTimeEmployee : EmployeeBase
    {
        // private int Id;
        // private string? Name;
        // private int Age;

        public FullTimeEmployee() { }
        FullTimeEmployee(int birthday)
        {
            Birthday = birthday;
            Test();
        }
        void getSalary()
        {
            Test();
        }
        private decimal Salary;
    }
    class PartTimeEmployee : EmployeeBase
    {
        // private int Id;
        // private string? Name;
        // private int Age;   
        private decimal HourRate;
    }
}
