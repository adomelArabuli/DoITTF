using System.Text;
using System.Threading.Channels;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exceptions
            using (CustomResource cr = new CustomResource())
            {
                cr.OpenResource();
                cr.UseResource();
            }

            #region FileStream
            //FileStream fileStream = null;
            //try
            //{
            //    fileStream = new FileStream("C:\\Users\\a.arabuli\\Desktop\\Create.txt", FileMode.Create);

            //    byte[] buffer = Encoding.ASCII.GetBytes("Hello world");

            //    fileStream.Write(buffer, 0, buffer.Length);

            //    throw new ApplicationException("Simulated exception");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Test");
            //}
            //finally
            //{
            //    if (fileStream != null)
            //    {
            //        fileStream.Close();
            //        Console.WriteLine("Filestream was closed");
            //    }
            //}
            //
            #endregion

            #region comment

            //string path = "C:\\Users\\a.arabuli\\Desktop\\roadmap1.txt";

            //int a = 5;
            //Console.WriteLine(a);
            //ChangeValue(a);
            //Console.WriteLine(a);

            //try
            //{
            //    //int result = DevideByZero(10, 5);

            //    //int userInput = ParseInt("Abc");

            //    //ReadFile(path);
            //}
            ////catch (DivideByZeroException ex)
            ////{
            ////    Console.WriteLine("Devide by zero is forbidden");
            ////}
            ////catch (FormatException ex)
            ////{
            ////    Console.WriteLine("Could not format");
            ////}
            ////catch (FileNotFoundException ex)
            ////{
            ////    Console.WriteLine("File not found");
            ////}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("General exception" + " " + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally executed");
            //}
            #endregion
        }

        static void ChangeValue(int a)
        {
            a++;
        }

        static int DevideByZero(int value1, int value2)
        {
            return value1 / value2;
        }

        static int ParseInt(string input)
        {
            return int.Parse(input);
        }

        static void ReadFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine($"The content of file is: {content}");
            }
        }
    }
}