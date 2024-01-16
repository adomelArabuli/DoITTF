namespace Lecture10_OperatorOverloading_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operator overloading
            // unary, binary, ternary
            // Overloadable operator     +,-,!,~, ++, --, +, -, *, /, %, ==, !=, >,<,>=,<=
            // Non overloadable operator &&, || +=, -=, *=, /=, %=, =, ., ?:, new, is, sizeof, typeof
            //int a = 10; 
            //int b = 20;

            //int result = a + b;
            //Console.WriteLine(result);

            //Box box1 = new Box(1, 2, 3);
            //Box box2 = new Box(1, 2, 3);

            //Console.WriteLine(box1 > box2);
            //Console.WriteLine(box1 < box2);

            //int number1 = 10;
            //double number2 = number1; // implicit conversion

            //int c = (int)number2; // explicit conversion

            //int[] array = new int[] { 1, 2, 3 };
            //Console.WriteLine(array[1]); // indexer

            //List<int> ints = new List<int>();
            //Console.WriteLine(ints[100]);
            //ints[0] = 1;
            //Console.WriteLine(ints.Capacity);

            StepAcademyCollection stepAcademyCollection = new StepAcademyCollection(100);
            stepAcademyCollection[0] = 32423;
            Console.WriteLine(stepAcademyCollection[0]);
            Console.WriteLine(stepAcademyCollection[1]);
        }
    }

    public class StepAcademyCollection
    {
        int[] items;

        int currentIndex;

        public StepAcademyCollection(int size)
        {
            items = new int[size];
            currentIndex = 0;
        }

        // create indexer
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < items.Length)
                {
                    return items[index];
                }
                else
                {
                    throw new IndexOutOfRangeException($"Index {index} is out of range.");
                }
            }
            set
            {
                if (index >= 0 && index < items.Length)
                {
                    items[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException($"Index {index} is out of range.");
                }
            }
        }

        public void Add(int value)
        {
            if(currentIndex < items.Length)
            {
                items[currentIndex] = value;
                currentIndex++;
            }
            else
            {
                Console.WriteLine("Collection is full");
            }
        }

    }

    class Box
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }

        public Box(int length, int width, int heigth)
        {
            Length = length;
            Width = width;
            Heigth = heigth;
        }

        public Box()
        {
            
        }

        ~Box() 
        {
            // descturctor(finlalizer)
        }

        public static Box operator +(Box box1, Box box2)
        {
            Box box = new Box();

            box.Length = box1.Length + box2.Length; 
            box.Width = box1.Width + box2.Width;
            box.Heigth = box1.Heigth + box2.Heigth;

            return box;
        }

        public static bool operator >(Box box1, Box box2)
        {
            if (box1.Length > box2.Length && box1.Width > box2.Width && box1.Heigth > box2.Heigth)
                return true;
            return false;
        }

        public static bool operator <(Box box1, Box box2)
        {
            if (box1.Length < box2.Length && box1.Width < box2.Width && box1.Heigth < box2.Heigth)
                return true;
            return false;
        }
    }
}