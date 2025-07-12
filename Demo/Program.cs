using Common;

namespace Demo
{
    internal class Program
    {
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

        }
    }
}
