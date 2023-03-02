using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileToByteArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\FileToArray\c.jpg";
            var fileByteArray = ConvertToByteArray(filePath);
            string converted = System.Text.Encoding.Default.GetString(fileByteArray);
            Console.WriteLine(converted);
            Console.ReadKey();
        }
        public static byte[] ConvertToByteArray(string filepath)
        {
            byte[] fileByteArray = File.ReadAllBytes(filepath);
            return fileByteArray;
        }
       
    }
}
