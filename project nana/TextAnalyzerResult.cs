using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_nana
{
    class TextAnalyzerResult
    {
        public TextAnalyzerResult
            (
            int wordsCount, 
            Dictionary<string, int> frequencyWords, 
            double wordsLengthAVG, 
            int countSpecialSymbols, 
            int stringCount, 
            int wordsMinLength, 
            int wordsMaxLength,
            List<string> text
            )
        {
            Text = text;
            WordsCount = wordsCount;
            FrequencyWords = frequencyWords;
            WordsLengthAVG = wordsLengthAVG;
            CountSpecialSymbols = countSpecialSymbols;
            StringCount = stringCount;
            WordsMinLength = wordsMinLength;
            WordsMaxLength = wordsMaxLength;
        }
        public List<string> Text { get; }
        public double WordsLengthAVG { get; }
        public int WordsCount { get; }
        public Dictionary<string, int> FrequencyWords { get; }
        public int CountSpecialSymbols { get; } 
        public int StringCount { get; }
        public int WordsMinLength { get; }
        public int WordsMaxLength { get; }
    }
}
