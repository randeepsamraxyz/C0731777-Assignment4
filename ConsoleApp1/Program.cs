//Section 5

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
            p.NumLetters();
        }
        public void NumLetters()
        {
            StreamReader reader = new StreamReader("U:/Users/731777/beowolf.txt");
            string script = reader.ReadToEnd();
            int num = 0;
            foreach (char letter in script)
            { num++; }
            Console.WriteLine("Total number of letters per word: " + num);

        }

    }
}









