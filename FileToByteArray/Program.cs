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
            string converted = Encoding.Default.GetString(fileByteArray);
            Console.WriteLine(converted);
            SaveByteArrayToFileWithBinaryWriter(fileByteArray, @"C:\FileToArray\converted.jpg");
            Console.ReadKey();
        }
        public static byte[] ConvertToByteArray(string filepath)
        {
            byte[] fileByteArray = File.ReadAllBytes(filepath);
            return fileByteArray;
        }
       public static void SaveByteArrayToFileWithBinaryWriter(byte[] data, string path)
        {
            var writer = new BinaryWriter(File.OpenWrite(path));
            writer.Write(data);
        }
    }
}
