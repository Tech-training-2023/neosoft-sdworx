using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Cat
    {
        private string[] cats = new string[10];
        private string[] indices = { "cat1", "cat2", "cat3", "cat4"};
        public string this[string i]
        {
            get { return cats[Array.IndexOf(indices, i)]; }
            set { cats[Array.IndexOf(indices, i)] = value; }
        }
    }
    public class FileOperations
    {
        public void ReadFileViaFileInfo()
        {
            FileInfo fi = new FileInfo(@"..\..\..\..\Data\data.txt");
            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            /*byte[] buffer = new byte[fs.Length];
            int bytesToRead= buffer.Length;
            int bytesRead = 0;
            while (bytesToRead>0)
            {
                int n = fs.Read(buffer,bytesRead,bytesToRead);
                if (n == 0)
                    break;
                bytesRead += n;
                bytesToRead -= n;
            }
            string fileString = Encoding.UTF8.GetString(buffer);*/

            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("I want to add this line to the stream");
            sw.Close();
        }

        public void BinaryReadWrite()
        {
            string pathBinary = @"..\..\..\..\Data\Info.dat";
            using (BinaryWriter bw = new BinaryWriter(File.Open(pathBinary, FileMode.Create)))
            {
                bw.Write("I am learning C# file handling");
                bw.Write("something something");
                Console.WriteLine("Write operation complete...............");
            }

            using (BinaryReader br = new BinaryReader(File.Open(pathBinary, FileMode.Open)))
            {
                Console.WriteLine("Read operation begins.........");
                Console.WriteLine(br.ReadString());
                Console.WriteLine(br.ReadString());
            }
        }
    }
}

