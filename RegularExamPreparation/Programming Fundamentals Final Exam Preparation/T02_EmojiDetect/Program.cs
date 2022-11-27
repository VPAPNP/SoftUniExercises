using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace T02_EmojiDetect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string patternEmoji = @"((\:\:)|(\*\*))(?<name>[A-Z][a-z]{2,})(\1)";
            string patternDigits = @"[0-9]";
            var regexDigits = new Regex(patternDigits);
            var regexEmojies = new Regex(patternEmoji);
            BigInteger coolTheshold = 1;
            MatchCollection matchDigits= regexDigits.Matches(inputText);
            MatchCollection matchEmojies = regexEmojies.Matches(inputText);
            
            foreach (var item in matchDigits)
            {
                coolTheshold = int.Parse(item.ToString()) * coolTheshold;
            }
            Console.WriteLine($"Cool threshold: {coolTheshold}");
            Console.WriteLine($"{matchEmojies.Count()} emojis found in the text. The cool ones are:");
            foreach (Match item in matchEmojies)
            {
                string emojiWord = item.Groups["name"].Value;
                long emojiCoolnes = 0;
                foreach ( var ch in emojiWord)
                {
                    emojiCoolnes += (int)ch;
                }
                if (emojiCoolnes >= coolTheshold)
                {
                    Console.WriteLine($"{item} ");
                }
            }

            
        }
    }
}
