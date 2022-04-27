using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTheoryCSharp
{
    class stringTheory
    {
        static private List<char> listOfAlpha = new List<char> {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
                'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'q', 'x', 'y', 'z'};

        private static List<char> GetListOfLetters(string text)
        {
            var listOfChars = new List<char>();
           
            foreach (var item in text)
            {
                char charLowercase = Char.ToLower(item);
                if (listOfAlpha.Contains(charLowercase))
                {
                    listOfChars.Add(charLowercase);
                }
            }
            return listOfChars;
        }

        public static bool IsPalindrome(string text)
        {
            List<char> ListOfChars = GetListOfLetters(text);
            List<char> ListOfCharsReversed = GetListOfLetters(text);
            ListOfCharsReversed.Reverse();

            var string1 = String.Join("", ListOfChars);
            var string2 = String.Join("", ListOfChars);
            return string1 == string2;
        }

        public static bool IsIsogram(string text)
        {
            List<char> ListOfChars = GetListOfLetters(text);
            List<char> ListOfCharsWithoutDuplicates = new List<char>();
            foreach (var item in ListOfChars)
            {
                if (!ListOfCharsWithoutDuplicates.Contains(item))
                {
                    ListOfCharsWithoutDuplicates.Add(item);
                }
            }

            var string1 = String.Join("", ListOfChars);
            var string2 = String.Join("", ListOfCharsWithoutDuplicates);

            return string1 == string2;
        }

        public static bool IsPangram(string text)
        {
            List<char> ListOfChars = GetListOfLetters(text);

            foreach (var item in listOfAlpha)
            {
                if (!ListOfChars.Contains(item))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsAnagram(string text1, string text2)
        {
            List<char> ListOfChars1 = GetListOfLetters(text1);
            List<char> ListOfChars2 = GetListOfLetters(text2);

            ListOfChars1.Sort();
            ListOfChars2.Sort();

            var string1 = String.Join("", ListOfChars1);
            var string2 = String.Join("", ListOfChars2);

            return string1 == string2;
        }
    }
}
