using System.Reflection;

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
    }

    internal class Program
    {
        public delegate void MyDelegate(string message);

        public delegate bool CheckDelegate(int  number);

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static bool IsPositive(int number)
        {
            return number > 0;
        }

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

            // delegates with anonymous methods, generic delegate(Func,Action), predicate
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