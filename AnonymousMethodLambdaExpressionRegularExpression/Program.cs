using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace AnonymousMethodLambdaExpressionRegularExpression
{
    internal class Program
    {
        //delegate void MyDelegate(string message);
        static void Main(string[] args)
        {
            #region AnonymousFunctionsLambdaExpressions
            //MyDelegate myDelegate = delegate (string message)
            //{
            //    Console.WriteLine($"anonumous method {message}");
            //};
            //myDelegate("Message from delegate");

            //MyDelegate myDeligate1 = message => Console.WriteLine($"Lambda expression {message}");
            //myDeligate1("Message from delegate");

            //Func<int, int, int> Add = (a, b) => a + b;
            //Console.WriteLine(Add(1, 2));

            //Button button = new Button();

            //button.Click += () => Console.WriteLine("Custom aciton on button click");

            //button.OnClick();
            #endregion

            // Regular expression(Regex) // pattern 
            // Name@DomainName.ge
            string emailPattern = @"^[a-zA-Z0-9.!_%+-/]+@[a-zA-Z0-9.#!\-]+\.[a-zA-Z]{2,}$";
            string userInput = "#########@gmail.com";
            Regex regex = new Regex(emailPattern);

            if (regex.IsMatch(userInput))
            {
                Console.WriteLine("Valid email");
            }
            else
            {
                Console.WriteLine("invalid email");
            }

            //string passwordPattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%^&*()\\-=_+{}[\\]:;<>,.?/~\\\\])\\S{8,}$";

            //Regex regex = new Regex(passwordPattern);
            //string userPassword = "Tbilisi1#";

            //if (regex.IsMatch(userPassword))
            //{
            //    Console.WriteLine("Valid pass");
            //}
            //else
            //{
            //    Console.WriteLine("invalid pass");
            //}
        }

    }

    //class Button
    //{
    //    public event Action Click = null;
    //    public void OnClick()
    //    {
    //        Console.WriteLine("Button clicked");
    //        Click();
    //    }
    //}
}