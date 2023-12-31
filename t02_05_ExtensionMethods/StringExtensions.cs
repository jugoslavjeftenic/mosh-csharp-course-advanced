﻿namespace t02_05_ExtensionMethods
{
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
            {
                throw new ArgumentOutOfRangeException("Number of words should be greater or equal to zero.");
            }

            if (numberOfWords == 0)
            {
                return "";
            }

            var words = str.Split(' ');

            if (words.Length <= numberOfWords)
            {
                return str;
            }

            return $"{string.Join(" ", words.Take(numberOfWords))}...";
        }
    }
}