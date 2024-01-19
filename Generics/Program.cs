using BenchmarkDotNet.Running;
using System.Collections;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inheritance, Genrics

            #region Comment

            //int x = 1; 
            //int y = 1; 

            //int k = 1; 
            //int j = 2;

            //string a = "a";
            //string b = "b";

            //bool c = true;
            //bool d = false;

            //Console.WriteLine($"{a} {b}");
            //Console.WriteLine($"{x} {y}");
            //Console.WriteLine($"{c} {d}");

            //GenericSwap(ref a, ref b);
            //GenericSwap(ref x, ref y);
            //GenericSwap(ref c, ref d);
            //GenericSwap(ref k, ref j);

            //Console.WriteLine($"{a} {b}");
            //Console.WriteLine($"{x} {y}");
            //Console.WriteLine($"{c} {d}");

            //Console.WriteLine(ReturnGenericType<int>());
            //Console.WriteLine(ReturnGenericType<string>());
            //Console.WriteLine(ReturnGenericType<double>());

            #endregion

            #region GenericMyList
            //var myListInt = new MyList<int>();
            //myListInt.Add(1);
            //myListInt.Add(2);
            //myListInt.Add(3);

            //var myListString = new MyList<string>();
            //myListString.Add("a");
            //myListString.Add("b");
            //myListString.Add("c");

            //for (int i = 0; i < myListInt.Count; i++)
            //{
            //    Console.WriteLine(myListInt[i]);
            //}

            //for (int i = 0; i < myListString.Count; i++)
            //{
            //    Console.WriteLine(myListString[i]);
            //}

            //foreach (var item in myListString)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            //BenchmarkRunner.Run(typeof(Program).Assembly);
            //BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);

            List<int> list = new List<int>(); // Generic
            list.Add(1);
            list.Add(2);
            ArrayList arrayList = new ArrayList(); //NonGeneric
            arrayList.Add(1);
            arrayList.Add("string");
        }

        //Swap

        public static void GenericSwap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static void UsualSwap(ref object a, ref object b)
        {
            object temp = a;
            a = b;
            b = temp;
        }

        static T ReturnGenericType<T>()
        {
            return default;
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
    }
}