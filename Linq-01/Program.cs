using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

using static Linq_01.ListGenerator;
namespace Linq_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicitly type local variable [var - dynamic]
            // Var vs Dynamic
            //  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // var::
            // compilar can detect the data type of local variable based on initial value
            // must be initialized
            // Can't initialized the local variable  by null
            // Can't Change the data type of local variable after initialization
            // Can't use Var as parameter or return type
            //  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // var data;// ERROR
            // var data = null; // ERROR
            // var Data = " SHIMAA "; // String 
            // Data = 0;// Invalid as local variable store string not integer value

            //  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // dynamic:: like var in JS
            // CLR : detect the datatype of local variable based on last data type , At Run Time
            // Don't need to be initialize
            // Can initlialize the local variable by null
            // can change the data type after initialization
            // can use dynamic key word as parameter or return type
            // Be careful when use Dynamic
            // Like Var in JS OR oBJECT IN c#
            //  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // dynamic Dataa = null;
            //dynamic Data = "shimaa";
            //Console.WriteLine(Data.GetType().Name);// String
            //Data = 12;
            //Console.WriteLine(Data.GetType().Name);// Int32
            //Data = 1.6;
            //Console.WriteLine(Data.GetType().Name);// Double
            //Data = 1.6f;
            //Console.WriteLine(Data.GetType().Name);// Single
            //Data = 1.7m;
            //Console.WriteLine(Data.GetType().Name);// Decimal
            //Data = true;
            //Console.WriteLine(Data.GetType().Name);// Boolean

            //var x = () => Console.WriteLine("Hello World");
            //var y = delegate() { Console.WriteLine("hello World"); };

            // dynamic y = delegate () { Console.WriteLine("hello World"); }; //ERROR maynf4 a use dynamic with delegate
            #endregion
            #region Anonymous Type
            //Employee Emp01 = new Employee() { Id = 1, Name = "shimaa", Salary = 50000 };
            //var Emp01 = new { Id = 1, Name = "shimaa", Salary = 50000 };
            //var Emp02 = new { Id = 1, Name = "shimaa", Salary = 50000 };
            //var Emp03 = Emp02 with { Id = 3}; // With Feature apeared in C# 10.0
            //Console.WriteLine(Emp03);
            //// Compilar Will override on ToString()
            //Console.WriteLine(Emp01);// { Id = 1, Name = shimaa, Salary = 50000 }
            //Console.WriteLine(Emp01.GetType().Name); //<> f__AnonymousType0`3
            //                                         // The Same Anonymous  As long as : the same property name [Case Sensitive] , the same property order
            //Console.WriteLine(Emp02.GetType().Name); //<> f__AnonymousType0`3
            //                                         // Anonumous :: Im-mutable type --> can't change Value After Creation
            //                                         //Emp01.Salary = 100000; // In-Valid Setting new Value
            //Console.WriteLine(Emp01.GetHashCode());
            //Console.WriteLine(Emp02.GetHashCode());
            //if (Emp03.Equals(Emp02))
            //    Console.WriteLine("E01 = E02");
            //else Console.WriteLine("E01 !=E02");
            #endregion
            #region Extension methods 
            //int num01 = 12345;
            //long num02 = 12345;
            //Console.WriteLine(IntExtension.Reverse(num01)); // 54321 Class Member Method
            //num01.Reverse();// Extension Method (this keyword) , class must be static
            //Console.WriteLine(num01.Reverse());
            //num02.Reverse();// Extension Method (this keyword) , class must be static
            //Console.WriteLine(num02.Reverse());
            #endregion
            #region LINQ Overview
            // LINQ :: Language Integrated Query 
            //      :: 40+ Extension [Linq Operator] Against Any data ==> data in sequance
            //      :: Regardless Data Store
            //      :: 13 category
            //      :: Linq operators Exists In Built-In Class "Enumerable"

            // Sequence :: object from class implement Interface "IEnumrable"
            // Local  Sequence :: L2O L2XML ==> Linq to object
            // Remote Sequence :: L2EF      ==> Linq to efcore
            // Input Sequence ----> Linq Operator ----> Output Sequence
            // Input Sequence ----> Linq Operator ----> One value
            //                ----> Linq Operator ----> Output Sequence

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // where
            //var result = Enumerable.Where(list, (N) => N % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.Write(item);
            //}

            // Any
            //var result = Enumerable.Any(list, (N) => N % 2 == 0);
            //Console.WriteLine(result);// true

            // Range
            //var result = Enumerable.Range(1,100);
            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //}
            #endregion
            #region Linq Syntax
            // Linq Syntax :: [ Fluent Syntax - Query Syntax(query expression) ]
            // 1. Fluent Syntax ==> use Linq Methods
            // 2. Linq operator as class member method
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // 1.1 Fluent Syntax ==> use Linq Methods
            //List<int> Nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            //var Result = Enumerable.Where(Nums , X => X%2 == 0);
            //foreach (var item in Result)
            //{
            //    Console.Write($"{item} "); // 2 4 6 8 10 12
            //}
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // 1.2 Linq operator as class member method [Recommended]
            //List<int> Nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            //var Result = Nums.Where(X => X % 2 == 0);
            //foreach (var item in Result)
            //{
            //    Console.Write($"{item} "); // 2 4 6 8 10 12
            //}
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // 2.0 Query Syntax(query expression) like SQL style
            // Start ==> From
            // End   ==> select - group by
            // Query Syntax Easier than Fluent (Join , Group By , Let , Into)
            //List<int> Nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            //var Result = 
            //             from N 
            //             in Nums where N%2 == 0 
            //             select N;

            //foreach (var item in Result) 
            //{
            //    Console.Write($"{item} "); // 2 4 6 8 10 12
            //}
            /* In SQL 
             select N
             from Numbers
             where N % 2 == 0
             */
            #endregion
            #region Linq Execution Ways 
            // Linq Execution Ways ::
            // 1.0 Differed  Execution way: 10 category
            // 2.0 Immediate Execution way: 3  category [Elements Operator - Casting Operator - Aggrigate Operator ]
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // 1.0 Differed  Execution way: 10 category
            //List<int> Nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var OutPut = Nums.Where(x => x%2 == 0); // Where() :: Differed
            //Nums.AddRange( new int[]{1, 100,104});
            //foreach (var item in OutPut) // Where hat4ta5el hena
            //{
            //    Console.Write($"{item} "); //2 4 6 8 10 12 14 100 104
            //}
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // 2.0 Immediate Execution way: 3  category [Elements Operator - Casting Operator - Aggrigate Operator ]
            //List<int> Nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var OutPut = Nums.Where(x => x % 2 == 0).ToList(); //Immediate :: Where hat4ta5el hena
            //Nums.AddRange(new int[] { 1, 100, 104 });
            //foreach (var item in OutPut) 
            //{
            //    Console.Write($"{item} "); // 2 4 6 8 10 12 14
            //}
            #endregion
            #region Setup Data
            //Console.WriteLine(ProductList[1]);
            //// ProductID: 2, ProductName: Chang, Category: Beverages, UnitPrice: 19.00, UnitsInStock: 17
            //Console.WriteLine();
            //Console.WriteLine(CustomerList[1]);
            ////323, Ana Trujillo Emparedados y helados, Avda. de la Constitución 2222, México D.F., , 05021, Mexico, (5) 555-4729, (5) 555-3745
            
            //var Result = ProductList.Where(P => P.UnitsInStock == 0).ToList();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}
