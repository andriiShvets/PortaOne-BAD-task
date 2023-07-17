using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BAD_task
{
    internal class UniqueChars
    {
        List<string> words = new List<string>();
        private string resultString = "";

        public char result;

        public UniqueChars(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                MessageBox.Show("enter your text, please");
            }
            else
            {
                words = Regex.Matches(text, @"\b\w+\b")
                                                  .OfType<Match>()
                                                  .Select(m => m.Value)
                                                  .ToList();
                foreach(var word in words)
                {
                    resultString += FindFirstUniqueCharInWord(word);
                }

                result = FindFirstUniqueCharInWord(resultString);
            }
        }

        

        private char FindFirstUniqueCharInWord(string word)
        {
            HashSet<char> visitedChars = new HashSet<char>();
            foreach (char c in word)
            {
                if (!visitedChars.Contains(c) && word.IndexOf(c, word.IndexOf(c) + 1) == -1)
                {
                    return c;
                }
                visitedChars.Add(c);
            }

            return ' ';
        }
    }
}
