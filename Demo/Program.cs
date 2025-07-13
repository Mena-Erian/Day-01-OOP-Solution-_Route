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

        }
    }
}
