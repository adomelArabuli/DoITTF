using System.Reflection;
using static Delegates.Program;

namespace Delegates
{
    public delegate void CallBackDelegate(int number);
    class Calculator
    {
        public static void DisplayResult(int number)
        {
            Console.WriteLine($"Result: {number}");
        }
        public void Add(int a, int b, in CallBackDelegate callBack)
        {
            int result = a + b;
            callBack(result);
        }

        public void Subtract(int a, int b, in CallBackDelegate callBack)
        {
            int result = a - b;
            callBack(result);
        }

        public void PerformOperation(int a, int b, OperationDelegate operation)
        {
            operation(a, b);
        }
    }

    internal class Program
    {
        public delegate void MyDelegate(string message);

        public delegate bool CheckDelegate(int number);


        public delegate void OperationDelegate(int x, int y);

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static bool IsPositive(int number)
        {
            return number > 0;
        }

        public delegate TResult MyGenericDelegate<T1, T2, TResult>(T1 param1, T2 param2);
        public delegate TResult MyGenericDelegate<T1, T2, T3, TResult>(T1 param1, T2 param2, T3 param3);

        static void Main(string[] args)
        {
            #region MulticastDelegate
            //MyDelegate myDelegate = null;

            //MyDelegate myDelegate1 = new MyDelegate(ShowUpperCase);

            //myDelegate += DisplayMessage;
            //myDelegate += ShowUpperCase;

            //myDelegate("Some text");

            //myDelegate -= DisplayMessage;
            //Console.WriteLine();
            //myDelegate("Some text");
            #endregion

            #region Callback
            //Calculator calculator = new Calculator();
            //CallBackDelegate callBack = new CallBackDelegate(Calculator.DisplayResult);

            //calculator.Add(5, 5, callBack);
            //calculator.Subtract(5, 5, callBack);
            #endregion

            #region DelegateWithPredicate

            //List<int> list = new List<int>() { 10,11,-2,-3,23,11,14,16,-55,22,-5};

            //CheckDelegate isEven = new CheckDelegate(IsEven);
            //CheckDelegate isPositive = new CheckDelegate(IsPositive);

            //var evenNumbers = FilterList(list, isEven);
            //var epositiveNumbers = FilterList(list, isPositive);

            #endregion

            #region Delegates with anonymous methods
            //Calculator calculator = new Calculator();
            //OperationDelegate addDelegate = delegate (int x, int y)
            //{
            //    Console.WriteLine($"Addition: {x + y}");
            //};

            //OperationDelegate subtractDelegate = delegate (int x, int y)
            //{
            //    Console.WriteLine($"Result: {x - y}");
            //};

            //OperationDelegate multiplicationDelegate = delegate (int x, int y)
            //{
            //    Console.WriteLine($"Result: {x * y}");
            //};

            //calculator.PerformOperation(10, 20, addDelegate);
            //calculator.PerformOperation(10, 20, subtractDelegate);
            //calculator.PerformOperation(10, 20, multiplicationDelegate);
            #endregion
            //Func
            //Func<int, int, string> addition = (a, b) => (a + b).ToString();
            //Func<int, int, int> subtraction = (a, b) => a - b;
            //Func<int, int, int, int> multiplication3Args = (a, b, c) => a * b * c;
            //string result = addition(10, 20);
            //int result1 = subtraction(10, 20);
            //int result2 = multiplication3Args(10, 20, 30);
            //Console.WriteLine(result);
            //Console.WriteLine(result1);
            //Console.WriteLine(result2);

            //Action
            //Action<string> printMessage = message => Console.WriteLine(message);
            //Action<int,int> Addition = (int a,int b) => Console.WriteLine(a + b);
            //printMessage("Hello");
            //Addition(1, 2);

            //Our own generic delegate
            //MyGenericDelegate<int,int,string> addition = (a,b) => (a + b).ToString();
            //string result = addition(1, 2);
            //Console.WriteLine(result);
            //MyGenericDelegate<string,string,string> print = (a,b) => (a + b).ToString();
            //string result1 = print("1","2");
            //Console.WriteLine(result1);

            //MyGenericDelegate<int,int,int,string> test = (a,b,c) => (a + b + c).ToString();
            //Console.WriteLine(test(1, 2, 3));
            
            //predicate

            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10,-1,-2,-22};
            Predicate<int> isEven = x => x % 2 == 0;
            Predicate<int> isOdd = x => x % 2 != 0;
            Predicate<int> isIsNegative = x => x < 0;

            List<int> evenIntList = list.FindAll(isEven);
            List<int> oddIntList = list.FindAll(isOdd);
            List<int> negativeIntList = list.FindAll(isIsNegative);
        }

        static List<int> FilterList(List<int> list, CheckDelegate checkDelegate)
        {
            List<int> result = new List<int>();
            foreach (int i in list)
            {
                if (checkDelegate(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public static void DisplayMessage(string message)
        {
            Console.WriteLine($"Message: {message}");
        }

        public static void ShowUpperCase(string message)
        {
            Console.WriteLine($"Upper case: {message.ToUpper()}");
        }
    }
}