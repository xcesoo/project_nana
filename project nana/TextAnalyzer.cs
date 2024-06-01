namespace project_nana
{
    public class TextAnalyzer
    {
        public TextAnalyzerResult Analyze(List<string> text)
        {
            List<string> words = ExtractWords(text);
            return new TextAnalyzerResult
                (
                words.Count,
                TakeFrequencyWords(words),
                TakeWordsLengthAVG(words),
                TakeSpecialSymbols(text),
                TakeCountStrings(text),
                TakeWordsLengthMin(words),
                TakeWordsLengthMax(words),
                text
                );
        }
        private List<string> ExtractWords(List<string> text)
        {
            List<string> words = new List<string>();
            char[] seperators = { ' ', ',', '.', '?', '!', '(', ')', ';', '+', '-', ':', '[', ']', '{', '}', '\\', '=', '>', '<' };
            for (int i = 0; i < text.Count; i++)
                words.AddRange(text[i].Split(seperators, StringSplitOptions.RemoveEmptyEntries));
            return words;
        }
        private Dictionary<string, int> TakeFrequencyWords(List<string> words)
        {
            var frequency_words = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string temp = word.ToLower();           // Записуємо слово у нижньому регистрі в тимчасову змінну
                if (frequency_words.ContainsKey(temp))  // Перевірка чи є слово в словнику.
                    frequency_words[temp]++;            // Якщо є - інкрементуємо значення
                else frequency_words[temp] = 1;         // Якщо нема - то створюємо новий елемент (ключ - значення)
            }
            /*frequency_words = frequency_words.Where(x => x.Value >= 50).ToDictionary(x => x.Key, x => x.Value); */// Беремо тільки часто вживаємі слова (частота вживань >=50)
            return frequency_words;
        }
        private double TakeWordsLengthAVG(List<string> words)
        {
            int avg_count = 0;
            foreach (string word in words) avg_count += word.Length;
            return Math.Round((avg_count / (double)words.Count), 3);
        }
        private int TakeSpecialSymbols(List<string> text)
        {
            int count_special_symbols = 0;
            for (int i = 0; i < text.Count; i++)
                count_special_symbols += text[i].Count(c => char.IsPunctuation(c));
            return count_special_symbols;
        }
        private int TakeCountStrings(List<string> text) => text.Count;
        private int TakeWordsLengthMin(List<string> words)
        {
            string wordMinLength = words[0];
            foreach (string word in words) if (word.Length < wordMinLength.Length) wordMinLength = word;
            return wordMinLength.Length;
        }
        private int TakeWordsLengthMax(List<string> words)
        {
            string wordMaxLength = words[0];
            foreach (string word in words) if (word.Length > wordMaxLength.Length) wordMaxLength = word;
            return wordMaxLength.Length;
        }

    }
}
