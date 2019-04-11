//Section 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        ArrayList Beowulf;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.Run();
        }

        public void Run() { this.ReadTextFiles(); }

        public void ReadTextFiles()
        {



            StreamReader reader = new StreamReader("U:/Users/731777/beowolf.txt");
            string script = reader.ReadToEnd();



            var text = script.Trim();
            int Count = 0, index = 0;


            while (index < text.Length)
            {


                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;


                Count++;

                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }

            Console.WriteLine("Total Number of Words are " + Count);

        }
    

        public int FindNumberOfBlankSpaces(string line)
        {
            //https://stackoverflow.com/questions/17812566/count-words-and-spaces-in-string-c-sharp
            int countletters = 0;
            int countSpaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c)) { countletters++; }
                if (char.IsWhiteSpace(c)) { countSpaces++; }
            }
            return countSpaces;


        }
    }
}
