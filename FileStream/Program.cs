using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace FileStreamNamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\a.arabuli\\Desktop\\text.txt";
            //using(StreamWriter sw = new StreamWriter(path))
            //{
            //    sw.WriteLine("Hello");
            //    sw.WriteLine("World");
            //}
            //string content = string.Empty;
            //using (StreamReader sr = new StreamReader(path))
            //{
            //    content = sr.ReadToEnd();
            //    Console.WriteLine(content);
            //}

            //using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            //{
            //    string stringToWrite = "Hello world";
            //    var buffer = Encoding.UTF8.GetBytes(stringToWrite);

            //    fs.Write(buffer, 0, buffer.Length);


            //}

            //using(FileStream fs = new FileStream(path, FileMode.Open))
            //{
            //    byte[] buffer = new byte[fs.Length];
            //    fs.Read(buffer, 0, buffer.Length);
            //    Console.WriteLine($"Data read from file: {Encoding.UTF8.GetString(buffer)}");
            //}

            //byte[] initialData = { 0x1, 0x2, 0x3, 0x4, 0x5 };

            //using(MemoryStream ms = new MemoryStream(initialData))
            //{
            //    ms.Seek(0, SeekOrigin.Begin);
            //    byte[] buffer = new byte[ms.Length];
            //    ms.Read(buffer, 0, (int)ms.Length);
            //    Console.WriteLine($"Initial data: {BitConverter.ToString(buffer)}");

            //    ms.Seek(0, SeekOrigin.Begin);

            //    byte[] newData = { 0x6, 0x7, 0x8 };
            //    ms.Write(newData, 0, newData.Length);

            //    ms.Seek(0, SeekOrigin.Begin);
            //    buffer = new byte[ms.Length];
            //    ms.Read(buffer, 0, (int)ms.Length);
            //    Console.WriteLine($"Initial data + new data: {BitConverter.ToString(buffer)}");
            //}

            //using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            //using (BufferedStream bfs = new BufferedStream(fs))
            //{
            //    byte[] buffer = System.Text.Encoding.UTF8.GetBytes("This is a sample text");

            //    bfs.Write(buffer, 0, buffer.Length);
                

            //    bfs.Flush();
            //}

            using(StringWriter sw = new StringWriter())
            {
                sw.WriteLine("Hello");
                sw.WriteLine("World");
                string content = sw.ToString();

                File.WriteAllText(path, content);

                File.ReadAllLines(path);
                //Console.WriteLine(string.Join('\n', File.ReadAllLines(path)));
                var array = File.ReadAllLines(path).ToList();

                array.ForEach(x => Console.Write(x));
                var newArray = array.Where(x => x.StartsWith('H'));
                foreach (var item in newArray)
                {
                    Console.WriteLine(item);
                }
            }


        }
    }
}