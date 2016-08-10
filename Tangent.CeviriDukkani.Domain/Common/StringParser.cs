using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Tangent.CeviriDukkani.Domain.Common
{
    public class StringParser
    {
        private string SourceText { get; set; }

        public StringParser(string sourceText)
        {
            this.SourceText = sourceText;
        }

        private List<string> SplitSentences()
        {
            // create a local string variable
            // set to contain the string passed it
            string sTemp = SourceText;

            // create the array list that will
            // be used to hold the sentences
            List<string> al = new List<string>();

            // split the sentences with a regular expression
            string[] splitSentences =
                Regex.Split(sTemp, @"(?<=['""A-Za-z0-9][\.\!\?])\s+(?=[A-Z])");

            // loop the sentences
            for (int i = 0; i < splitSentences.Length; i++)
            {
                // clean up the sentence one more time, trim it,
                // and add it to the array list
                string sSingleSentence =
                    splitSentences[i].Replace(Environment.NewLine, string.Empty);
                al.Add(sSingleSentence.Trim());
            }

            // return the arraylist with
            // all sentences added
            return al;
        }
        
        public int GenerateCharacterCount(bool withoutWhitespaces = false)
        {
            var regexForReplace = withoutWhitespaces
                                    ? @"[^A-Za-z0-9]"
                                    : @"[^A-Za-z0-9\s]";
            string sxTemp = SourceText.Replace(Environment.NewLine, string.Empty);

            var clearedText = Regex.Replace(sxTemp, regexForReplace, string.Empty);
            return clearedText.Length;
        }

        public int GenerateWordCount(Func<List<string>> action)
        {
            // declare a return value
            int rtn = 0;

            var sentences = action();

            // iterate through the entire list
            // of sentences
            foreach (string sSentence in sentences)
            {
                // define an empty space as the split
                // character
                char[] arrSplitChars = { ' ' };

                // create a string array and populate
                // it with a split on the current sentence;
                // use the string split option to remove
                // empty entries so that empty sentences do not
                // make it into the word count.
                var arrWords = sSentence.Split(arrSplitChars, StringSplitOptions.RemoveEmptyEntries);
                rtn += arrWords.Length;
            }

            // return the final word count
            return rtn;
        }

        public int GenerateSentenceCount(Func<List<string>> action)
        {
            // create a return value
            int rtn = 0;

            var sentences = action();
            // set the return value to
            // the length of the sentences array
            rtn = sentences.Count;

            // return the count
            return rtn;
        }

        public List<string> SplitByCount(int count)
        {
            var charCount = GenerateCharacterCount();
            var sentences = SplitSentences();
            var avgCharCountByPart = charCount / count;

            var result = new List<string>();

            var sum = 0;
            var lastSentenceCount = 0;
            for (int j = 0; j < sentences.Count; j++)
            {
                sum += sentences[j].Length;

                if (sum >= avgCharCountByPart)
                {
                    result.Add(string.Join(" ", sentences.Skip(lastSentenceCount).Take(j - lastSentenceCount)));
                    lastSentenceCount = j;
                    sum = 0;
                }
            }
            result.Add(string.Join(" ", sentences.Skip(lastSentenceCount).Take(sentences.Count - lastSentenceCount)));

            return result;
        }
    }
}
