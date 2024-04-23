using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    public class CountingWords
    {
        public static int ByteCount(string fullText)
        {
            var bytes = Encoding.UTF8.GetByteCount(fullText);
            return bytes;
        }

        public static int LineCount(string fullText)
        {
            int ans;
            var textArr = fullText.Split('\r');
            ans = fullText.Count(x => x == '\n');   
            return ans;
        }
        public static int WordCount(string fullText)
        {
            char[] delimiters = new char[] { ' ', '\n', '\r', '\t' };
            int ans = fullText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            return ans;
        }
        public static int CharacterCount(string fullText)
        {
            int wc = fullText.Length;
            return wc;
        }
    }
}
