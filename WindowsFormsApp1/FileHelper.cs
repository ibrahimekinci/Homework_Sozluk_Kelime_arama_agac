using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class FileHelper
    {
        private static string filePath = "sozluk.txt";
        public static string GetFile()
        {
            try
            {
                if (File.Exists(filePath))
                    return System.IO.File.ReadAllText(filePath);
                return null;
            }
            catch
            {
                return null;
            }
        }
        public static string[] GetFileArray()
        {
            try
            {
                if (File.Exists(filePath))
                    return System.IO.File.ReadAllLines(filePath);
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
