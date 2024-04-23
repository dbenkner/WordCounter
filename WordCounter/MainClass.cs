using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WordCounter;


namespace MainC
{
    class MainClass
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Word Counter");
            if(args.Length == 0)
            {
                return 0;
            }
            Console.WriteLine(args.Length);
            if(args.Length > 1) inputChecker(args);
            if (args.Length == 1) {
                if (!validFileInput(args[0])) return 1; 
                StringBuilder sb = new StringBuilder();
                var str = FileReader.ReadFile(args[0]);
                if(str == "Exception") { return 1; }    
                sb.Append(CountingWords.ByteCount(str) + " ");
                sb.Append(CountingWords.LineCount(str) + " ");
                sb.Append(CountingWords.WordCount(str));
                Console.WriteLine(sb.ToString());
                return 0;
            }
            var input = Console.ReadLine();
            if (input.Contains(".txt"))
            {
                string[] argsPlus = {args[0], input};
                inputChecker(argsPlus);
                return 0;
            }
      
            return 0;
        }
        private static int inputChecker(string[] ars)
        {
            if (!validFileInput(ars[1]))
            {
                return 1;
            }
            var str = FileReader.ReadFile(ars[1]);
            if (str == "Exception") { return 1; }

            if (ars[0] == "-c")
            {              
               int totalBytes = CountingWords.ByteCount(str);
                Console.WriteLine(totalBytes);
                return 0;
            }
            if (ars[0].ToLower() == "-l")
            {
                Console.WriteLine(CountingWords.LineCount(str));
                return 0;
            }
            if (ars[0].ToLower() == "-w")
            {
                Console.WriteLine(CountingWords.WordCount(str));
                return 0;
            }
            if (ars[0].ToLower() == "-m")
            {
                Console.WriteLine(CountingWords.CharacterCount(str));
                return 0;
            }
            Console.WriteLine("Invalid Command");
            return 1;
        }
        private static bool validFileInput(string fileName)
        {
            if(fileName.EndsWith(".txt") || fileName.EndsWith(".text"))
            {
                return true;
            }
            Console.WriteLine("Invalid File Must be a Text File! Only .txt or .text Files!");
            return false;
        }
    }
}
