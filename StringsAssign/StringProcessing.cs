using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringsAssign
{
    public class StringProcessing
    {

        public static int WordsCounter(string text)
        {
            char[] delimiter = {' '};

            string[] words = text.Split(delimiter);

            return words.Length;
        }


        public static int SentenceCounter(string text)
        {
            char[] delimiter = {'.','?','!',};

            string[] sentences = text.Split(delimiter,StringSplitOptions.RemoveEmptyEntries);

            return sentences.Length;    
        }

        public static int MatcherCount(string text , string pattern)
        {
            string[] splitedWords = text.ToLower().Split(" ");

            var result  = from p in splitedWords
                          where p.Contains(pattern)
                          select p;
            return result.Count();  

            //string regexPattern = $@"\b{pattern}\b";
            //return Regex.Matches(text,regexPattern).Count();    
        }

        public static string ReverseString(string input)
        {
            int n = input.Length;
            char[] inputTochar = input.ToCharArray();   
           

            for(int i = 0; i < n / 2; i++)
            {
                char temp = inputTochar[i];
                inputTochar[i] = inputTochar[n-i-1];
                inputTochar[n - i - 1] = temp;  
            }

            return new string(inputTochar); 
        }

        public static string ReplaceWithPattern(string text ,
            string pattern) =>   text.Replace(pattern, "OOP");


        public static string RefactorFirstSentence(string text)
        {
            char[] delimiter = {'.','?','!'};
            string[] sentences = text.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            if(sentences.Length > 0)
            {
                string[] words = sentences[0].Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                return string.Join("-", words);
            }

            return "NotFount"; 
        }

        
    }
}
