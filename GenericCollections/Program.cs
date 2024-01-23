using System.Collections;
using System.Diagnostics.SymbolStore;

namespace GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // typesafe // AWS // AZURE // RabitMQ
            //Generic collections

            var list = new List<int>();
            var listString = new List<string>();
            list.Add(0);
            list.Remove(0);

            SortedList<string, int> keyValuePairs = new SortedList<string, int>(); // key can not be dublicated
            SortedList<string, int> keyValuePairs1 = new SortedList<string, int>();

            keyValuePairs.Add("giorgi", 2312);
            keyValuePairs.Add("lana", 3242);
            keyValuePairs.Add("nana", 12);
            keyValuePairs.Add("beqa", 213);
            keyValuePairs.Add("kote", 453);

            var keyValuePairs2 = new Dictionary<string, int>();
            keyValuePairs2.Add("giorgi", 2312);
            keyValuePairs2.Add("lana", 3242);
            keyValuePairs2.Add("nana", 12);
            keyValuePairs2.Add("beqa", 213);


            var keyValuePairs3 = new SortedDictionary<string, int>();
            keyValuePairs3.Add("giorgi", 2312);
            keyValuePairs3.Add("lana", 3242);
            keyValuePairs3.Add("nana", 12);
            keyValuePairs3.Add("beqa", 213);
            keyValuePairs3.Add("kote", 453);

            var stack = new Stack<string>(); // FILO
            stack.Push("giorgi");
            stack.Push("lana");
            stack.Push("nana");

            stack.Pop();
            stack.Pop();
            stack.Pop();

            Queue<string> strings = new Queue<string>(); // FIFO
            strings.Enqueue("giorgi");
            strings.Enqueue("lana");
            strings.Enqueue("nana");

            strings.Dequeue();
            strings.Dequeue();
            strings.Dequeue();

            HashSet<string> strings1 = new HashSet<string>(); // dublications not allowed, exception is not thrown
            strings1.Add("giorgi");
            strings1.Add("tekla");
            strings1.Add("giorgi");
            strings1.Add("lana");


            SortedSet<string> strings2 = new SortedSet<string>(); // dublications not allowed, exception is not thrown(it is sorted)
            strings2.Add("giorgi");
            strings2.Add("tekla");
            strings2.Add("giorgi");
            strings2.Add("lana");

            LinkedList<string> strings3 = new LinkedList<string>();
            strings3.AddFirst("giorgi");
            strings3.AddFirst("lana");
            strings3.AddLast("tekla");
            strings3.AddFirst("kote");


            // Non-generic collections
            ArrayList arrayList = new ArrayList();
            arrayList.Add(true);
            arrayList.Add("Hello");
            arrayList.Add(10);


            SortedList sortedList = new SortedList(); // key dublication not allowed, all keys must be the same type
            sortedList.Add(3, "three");
            sortedList.Add(2, "two");
            sortedList.Add(1, 1);
            sortedList.Add(4, true);

            Stack stack1 = new Stack();
            stack1.Push("hello");
            stack1.Push(1);
            stack1.Push(true);
            stack1.Push(false);
            stack1.Push(1.5);

            stack1.Pop();
            stack1.Pop();
            stack1.Pop();
            stack1.Pop();

            Queue queue = new Queue();
            queue.Enqueue("hello");
            queue.Enqueue(1);
            queue.Enqueue(false);
            queue.Enqueue(true);
            queue.Enqueue(5.5);

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            Hashtable hashtable = new Hashtable(); // dublication not allowed, keys can be differnet types 
            hashtable.Add("hello", 1);
            hashtable.Add("wordl", 1);
            hashtable.Add("ado", 1);
            hashtable.Add(1, 1);
            hashtable.Add(true, 1);

            BitArray bitArray = new BitArray(10,true);
            bitArray[0] = false;
            bitArray[1] = true;
            bitArray[2] = false;
            bitArray[3] = false;

            BitArray bits1 = new BitArray(new bool[] { true, false, true });
            BitArray bits2 = new BitArray(new bool[] { false, true, true});

            BitArray result1 = bits1.And(bits2);
            BitArray result2 = bits1.Or(bits2);

            foreach (var bit in bitArray)
            {
                Console.Write((bool)bit ? "a" : "0");
            }
        }
    }
}