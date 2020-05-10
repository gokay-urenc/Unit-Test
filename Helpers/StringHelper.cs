using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class StringHelper
    {
        static void Main(string[] args)
        {
        }

        public static string DeleteUnnecessarySpaces(string phrase)
        {
            phrase = phrase.Trim();
            string newPhrase = string.Empty;
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == ' ' && phrase[i + 1] == ' ')
                    continue;
                newPhrase += phrase[i];
            }
            return newPhrase;
        }
    }
}