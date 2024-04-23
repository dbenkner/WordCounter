using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    public class FileReader
    {
         public static string ReadFile(string path)
        {
            string res;
            try
            {
                var file = File.ReadAllBytes(path);
                res = Encoding.UTF8.GetString(file);
                return res;
            } catch (Exception System) { 
                Console.WriteLine("Invalid File!");   
                Console.WriteLine(System);
                res = "Exception";
                return res;
            }
           
        }
    }
}
