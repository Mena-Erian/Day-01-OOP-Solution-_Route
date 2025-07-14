using System.ComponentModel;

namespace Assignment
{
    internal class Program
    {
        enum WeekDays /*: byte*/
        {
            Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        enum Season : byte
        {
            Spring = 1, Summer, Autumn, Winter
        }
        [Flags]
        enum Permissions : byte
        {
            Read = 1, Write = 2, Delete = 4, Execute = 8
        }
        enum Colors
        {
            Red = 1, Green, Blue
        }
        static void Main()
        {
            #region 1.Print Week Days From Enum
            /// WeekDays weekDays = WeekDays.Monday;
            /// 
            /// for (int i = 1; i < 8; i++)
            /// {
            ///     weekDays = (WeekDays)i;
            ///     Console.WriteLine(weekDays);
            /// }
            #endregion

            #region 2.Season Month Rang
            /// Season season;
            /// do
            /// {
            ///     Console.Write("Please Enter Season Name: ");
            /// 
            /// }
            /// while (!Enum.TryParse(Console.ReadLine(), true, out season));
            /// 
            /// switch (season)
            /// {
            ///     case Season.Spring:
            ///         Console.WriteLine("spring march to may");
            ///         break;
            ///     case Season.Summer:
            ///         Console.WriteLine("summer june to august");
            ///         break;
            ///     case Season.Autumn:
            ///         Console.WriteLine("autumn September to November");
            ///         break;
            ///     case Season.Winter:
            ///         Console.WriteLine("winter December to February");
            ///         break;
            /// }
            #endregion

            #region 3.Permissions
            /// Permissions permission = (Permissions)6;
            /// Console.WriteLine(permission); //Write, Delete
            /// 
            /// if (permission.Equals(Permissions.Read))
            /// {
            ///     Console.WriteLine("You can Read");
            /// }
            /// else
            /// {
            ///     Console.WriteLine("You can't Read");
            /// }
            #endregion

            #region 4.Colors
            /// Colors UserColor;
            /// 
            /// Console.Write("Please Enter Color Name: ");
            /// if (Enum.TryParse(Console.ReadLine(), true, out UserColor))
            /// {
            ///     Console.WriteLine($"Your Color ( {UserColor} ) is Primary Color");
            /// }
            /// else
            /// {
            ///     Console.WriteLine($"Your Input is Not a Primary Color");
            /// }
            #endregion
        }
    }
}
