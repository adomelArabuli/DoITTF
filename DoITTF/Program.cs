using System.Diagnostics;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;

namespace DoITTF
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Method1(myClass);
            Method2(myClass);

            MyClass2 myClass2 = new MyClass2();
            Method1(myClass2);
            Method2(myClass2);
        }

        static void Method1(IFirstInterface firstInterface)
        {
            firstInterface.Action();
        }

        static void Method2(ISecondInterface secondInterface)
        {
            secondInterface.Action();
        }

    }

    public interface IFirstInterface
    {
        void Action();
    }

    public interface ISecondInterface
    {
        void Action();
    }

    class MyClass : IFirstInterface, ISecondInterface
    {
        public void Action()
        {
            Console.WriteLine("Myclass action");
        }
    }

    class MyClass2 : IFirstInterface, ISecondInterface
    {
        void IFirstInterface.Action()
        {
            Console.WriteLine("FirstInterface implementation");
        }

        void ISecondInterface.Action()
        {
            Console.WriteLine("SecondInterface implementation");
        }
    }
}