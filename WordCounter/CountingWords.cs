using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    public class CountingWords
    {
        public static int ByteCount(string path)
        {
            return File.ReadAllBytes(path).Length;  
        }

        public static int LineCount(string path)
        {
            int ans;
            ans = File.ReadAllLines(path).Length;  
            return ans;
        }
        public static int WordCount(string path)
        {
            StreamReader sr = new StreamReader(path);
            var sample = sr.ReadToEnd().ToString();
            sr.Close(); 
            char[] delimiters = new char[] { ' ', '\n', '\r', '\t' };
            int ans = sample.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            return ans;
        }
    }
}
