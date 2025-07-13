/*global*/ //using Common; // if i use this in most

namespace Demo
{
    internal class Program
    {
        //public static void Run (IVechile car)
        //{
        //    car.Accelerate();
        //}
        static void Main()
        {
            #region Access Modifiers

            /**
             * All have Accessablite scope
             * And Just 3 have inhertant Scope with Accessablite scope
             * 
             * 1- private
             * 2- private protected //Inhertant Scope
             * 3- protected //Inhertant Scope
             * 4- internal
             * 5- internal protected //Inhertant Scope
             * 6- public
             * 7- file
             * 
             */

            #endregion

            // TypeA i Can't Access Here becouse is internal and they in another project
            // Now They Public so i can access
            TypeA typeA = new TypeA();
            //typeA.X = 10; [Invalid] X is inaccessible due to its protection level "private".
            //typeA.Y = 20; [InValid] Y is inaccessible due to its protection level  "internal"
            typeA.Z = 30; // [Valid]  Z is "public"

            EmployeeBase employee = new EmployeeBase();
            FullTimeEmployee employee2 = new FullTimeEmployee();

            TypeD obj = new TypeD();
            TypeB typeB = new TypeB();
            //typeB.TestTypeB();

            

            //obj.
            //obj.X; not vaild
            //obj.Y; not vaild
            //obj.Z = 30; //Here not vaild is internal
        }
    }
}
