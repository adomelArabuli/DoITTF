using System.Threading.Channels;

namespace AnonymousMethodLambdaExpressionRegularExpression
{
    internal class Program
    {
        //delegate void MyDelegate(string message);
        static void Main(string[] args)
        {
            //MyDelegate myDelegate = delegate (string message)
            //{
            //    Console.WriteLine($"anonumous method {message}");
            //};
            //myDelegate("Message from delegate");

            //MyDelegate myDeligate1 = message => Console.WriteLine($"Lambda expression {message}");
            //myDeligate1("Message from delegate");

            //Func<int, int, int> Add = (a, b) => a + b;
            //Console.WriteLine(Add(1, 2));

            Button button = new Button();

            button.Click += () => Console.WriteLine("Custom aciton on button click");

            button.OnClick();


        }

    }

    class Button
    {
        public event Action Click = null;
        public void OnClick()
        {
            Console.WriteLine("Button clicked");
            Click();
        }
    }
}