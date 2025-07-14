/*global*/ //using Common; // if i use this in most

namespace Demo
{
    enum Branch : byte
    {
        Dokki = 200, Maadi, NaserCity, Alex = 253, BNS, SmartVillage
    }
    enum Grade : byte /*: int*/ // NumaricType = int [default]
    {
        A, B, C, D, F   // Labels
    }
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Salary { get; set; }
        public Gender Gender { get; set; }
    }
    enum Gender : byte
    {
        // Don't Make label = 0
        yy = 0, Male = 1, Female = 2
    }

    // byte = 8 bites [0: 255]
    [Flags]
    enum Permission : byte /* : Short*/
    {
        /* from byte to decimal => 2pow index*/
        Read = 1, write = 2, Excute = 4, Update = 8, Test = 16, XX = 32, YY = 64, ZZ = 128,
        /*2pow(0)=1,2pow(1)=2,2pow(2)=4,2pow(3)=8,2pow(4)=16,2pow(5)=32,2pow(6)=64,2pow(7)=128     */
    }
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

            #region Examples
            ///// TypeA i Can't Access Here becouse is internal and they in another project
            ///// Now They Public so i can access
            ///TypeA typeA = new TypeA();
            /////typeA.X = 10; [Invalid] X is inaccessible due to its protection level "private".
            /////typeA.Y = 20; [InValid] Y is inaccessible due to its protection level  "internal"
            ///typeA.Z = 30; // [Valid]  Z is "public"
            ///
            ///EmployeeBase employee = new EmployeeBase();
            ///FullTimeEmployee employee2 = new FullTimeEmployee();
            ///
            ///TypeD obj = new TypeD();
            ///TypeB typeB = new TypeB();
            /////typeB.TestTypeB();
            ///
            ///
            ///
            /////obj.
            /////obj.X; not vaild
            /////obj.Y; not vaild
            /////obj.Z = 30; //Here not vaild is internal
            #endregion

            #endregion

            #region Enum

            #region Part 01
            ///Person person = new Person();
            ///person.Id = 1001;
            ///person.Name = "Mena";
            ///person.Salary = 10_000;
            ///person.Gender = Gender.Male;

            /// Gender myGender = Gender.Female;
            /// Console.WriteLine(myGender);

            /// Grade myGrade = Grade.A; // 1 Byte // 4 Bytes
            ///
            /// myGrade = (Grade)3;  // D
            /// myGrade = (Grade)10; // 10
            ///
            /// Console.WriteLine(myGrade); 
            #endregion

            #region Part 02
            /// //Gender myGender = (Gender) "Male"; // casting operatore is function, 
            /// // should from numaric type to Gender not from string
            /// 
            /// Gender myGender;
            /// 
            /// myGender = /*UnBoxing*/ (Gender)Enum.Parse(typeof(Gender) /*Boxing*/ , "male", true); // Boxing then UnBoxing
            /// //      ValueType | parse() it will save int value in object and return it {{{ Boxing }}},
            /// //                | And i Maked Explicit Cast from object to enum(int)
            /// //                                               - to save it in variable {{{ UnBoxing }}} 
            /// myGender = Enum.Parse<Gender>("male", true); // Here use genaric so we don't have Boxing and UnBoxing
            /// 
            /// Enum.TryParse(typeof(Gender), "Male", true, out object? result /*Boxing*/); // Here alos Make Boxing && UnBoxing
            /// myGender = (Gender) /*UnBoxing*/ (result ?? Gender.Male);
            /// 
            /// Enum.TryParse/*<Gender>*/("any ", true, out myGender); // Not Make Boxing && UnBoxing
            /// 
            /// 
            /// Console.WriteLine(myGender);
            #endregion

            #region Part 03
            /// Permission myPermission = (Permission)3; //Read, write
            /// //(Binary Compare)
            /// /* 1,2,4,8,16,32,64,128  */
            /// //That if you wand to add permission
            /// //              1 + 2 = 3   |       Ecute = 4
            /// myPermission = myPermission | Permission.Excute; // 3 | 4
            /// //                  (Add Permission)            [0011]|[0100] = [0111]
            /// //                                            back to decimal = (8*0)+(4*1)+(2*1)+(1*1)
            /// //                                                            =  0+4+2+1 = 7
            /// Console.WriteLine(myPermission); //Read, write, Excute        =    7 
            /// 
            /// /// //myPermission = 7
            /// myPermission = myPermission & Permission.write;  // 7 & 2
            /// //                                              [0111]&[0010] = [0010]
            /// //                                            back to decimal = (8*0)+(4*0)+(2*1)+(1*0)
            /// //                                                            = 0+0+2+0 = 2
            /// Console.WriteLine(myPermission); // write                     =     2
            /// 
            /// myPermission &= ~(Permission.write);  // 7 & ~(2) =>
            /// //                                [0111]&~[0010] =>
            /// //                                [0111]& [1101] = [0101]
            /// //                              back to decimal = (8*0)+(4*1)+(2*0)+(1*1)
            /// //                                              = 0+4+0+1 = 5
            /// Console.WriteLine(myPermission); //Read, Excute           = 5 
            /// 
            /// /// What does XOR(^) do? It compares each bit of two numbers:
            /// /// If the bits are the same → result is 0
            /// /// If the bits are different → result is 1
            /// 
            /// 
            /// /* 1,2,4,8,16,32,64,128  */
            /// //   f(5)     =    5 ^ 4     
            /// myPermission ^= Permission.Excute;
            /// Console.WriteLine(myPermission); //Write     
            /// myPermission ^= Permission.Excute; // like toggle
            /// Console.WriteLine(myPermission); //Write , Excute  
            /// 
            /// // `|=`  => to Add
            /// // `&= ~()  `  => to Delete
            /// // `^=` => to Toggle

            #endregion

            #endregion
        }
    }
}
