using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    // What You Can Write inside the Namespace
    /**
     * 1. Class
     * 2. Struct [stands for structure]
     * 3. Interface
     * 4. Enum
     * 5. Delegate // After compilation it will be Class
     * 6. Record [C# 9.0 NEW Feature (.NET 5.0)]
     * 7. Nested Namespace
     * 
     */

    // Allowed Access Modifires inside the Namespace?
    // 1. internal [Default Access Modifier] // I can't access from another project
    // 2. public
    // 3. file [C# 11.0 Feature (.NET 7.0)] // just can Access in the Same File even this in another class it also can Access


    namespace Models
    {
        class Employee
        {

        }
    }

    public class TypeA
    {
        // What You Can Write Inside the Class?
        /**
         * 01. Fields (Attributes | Member Variables)
         * 02. Properties (Full, Automatic)
         * 03. Indexers (Special Property)
         * 04. Methods
         * 05. Operators
         * 06. Constructors
         * 07. Destructors
         * 08. Events
         * 09. Static Members (Static Fields, Static Properties, Static Methods, Static Constructor) and Constants
         * 10. Nested Types (Classes, Structs, Interfaces, Enum and etc..)
         * 
         */

        // Allwed Access Modifiers inside the Class?
        /**
         * 
         * 1- private
         * 2- private protected //Inhertant Scope
         * 3- protected //Inhertant Scope
         * 4- internal
         * 5- internal protected //Inhertant Scope
         * 6- public
         * 
         */


        /// Default Access Modifier inside the Class and the Struct is 'private'

    }

    public struct TypeZ
    {
        // What You Can Write Inside the Struct?
        /**
         * 01. Fields (Attributes | Member Variables)
         * 02. Properties (Full, Automatic)
         * 03. Indexers (Special Property)
         * 04. Methods
         * 05. Operators
         * 06. Constructors
         * 07. Events
         * 08. Static Members (Static Fields, Static Properties, Static Methods, Static Constructor) and Constants
         * 09. Nested Types (Classes, Structs, Interfaces, Enum and etc..)
         */

        // Allwed Access Modifiers inside the Struct?
        /**
         * 
         * 1- private
         * 2- internal
         * 3- public
         * 
         */

        /// Default Access Modifier inside the Class and the Struct is 'private'

    }

    public interface IBehavior
    {
        /// What You Can Write inside the Interface?
        /// 1. Signature For Mehtod
        /// 2. Signature For Property
        /// 3. Default Implemented Method [C# 8.0 NEW Feature (.NET Core 3.1)]
        /// 4. Static Members [C# 8.0 NEW Feature (.NET Core 3.1)]
        ///      - Static Method
        ///      - Static Property
        ///      - Static Fields [Constants]
        ///      - Static Events


        // Allowed Access Modifiers inside the Interface?
        /// 1. private protected //Inhertant Scope
        /// 2. protected //Inhertant Scope
        /// 3. internal
        /// 4. internal protected //Inhertant Scope
        /// 5. public

        // Default Access Modifier inside the Interface is 'public'.
    }
    //public interface IVehcile
    //{
    //    public void Accelerate();
    //    public void Decelerate()
    //    {

    //    }
    //}

    //public interface IFlyableVechile
    //{
    //    // Is Code Contract
    //    // behavers

    //    public void Accelerate();
    //}
    //public class Car
    //{

    //}
    //public class BMWCar : Car, IVechile
    //{
    //    public void Accelerate()
    //    {

    //    }
    //}
    //public class AudiCar : Car,IVechile
    //{
    //    public void Accelerate()
    //    {

    //    }
    //}
    //public class Airplan
    //{

    //}
    //public class F16Airplan : Airplan, IVechile, IFlyableVechile
    //{
    //    //public void Accelerate()
    //    //{
    //    //    throw new NotImplementedException();
    //    //}

    //    // Can't Be Public
    //    void IVechile.Accelerate()
    //    {
    //        throw new NotImplementedException();
    //    }
    //    void IFlyableVechile.Accelerate()
    //    {
    //        throw new NotImplementedException();
    //    }

    //}

    public enum Gender : byte // Numaric Type [Default: int]
    {
        //Male =0,Female=1
        Male, Female
        //Male = 100,Female = 255
    }

    public delegate string Func(int Number); // C# Feature (Startage Design pattern)

    public record Person (int Id, string Name); //Begian C# 9.0 // like Class & Struct
}
