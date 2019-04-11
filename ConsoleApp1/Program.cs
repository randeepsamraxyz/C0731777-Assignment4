//Section 3

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
            p.Wordfind();
        }
        public void Wordfind()
        {
            int chr = 0;
            foreach (var line in File.ReadAllLines("U:/Users/731777/beowolf.txt"))
            {
                if (line.Contains("sea") && line.Contains("fare"))
                {

                    chr++;
                }

            }
            Console.WriteLine("Total words sea and fare in File are:" + chr);
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
