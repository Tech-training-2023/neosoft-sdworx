using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
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
    }
}
