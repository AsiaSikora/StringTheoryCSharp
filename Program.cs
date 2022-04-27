using System;

namespace StringTheoryCSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(stringTheory.IsPalindrome("Mr. Owl ate my metal worm!"));

            Console.WriteLine(stringTheory.IsIsogram("uncopyrightables"));

            Console.WriteLine(stringTheory.IsPangram("The quick brown fox jumps over the lazy dog"));

            Console.WriteLine(stringTheory.IsAnagram("Justin Timberlake", "I'm a jerk but listen"));
        }
    }
}
