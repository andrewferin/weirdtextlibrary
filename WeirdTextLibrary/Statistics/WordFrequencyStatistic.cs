using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeirdTextLibrary.Statistics
{
    public class WordFrequency
    {
        public readonly string Word;
        public readonly int Frequency;

        public WordFrequency(string word, int frequency)
        {
            Word = word;
            Frequency = frequency;
        }

        public override bool Equals(object other)
        {
            WordFrequency b = other as WordFrequency;

            if (b != null)
                return string.Equals(this.Word, b.Word, StringComparison.CurrentCultureIgnoreCase);

            return false;
        }
    }

    /// <summary>
    /// Статистика частоты слов
    /// </summary>
    public class WordFrequencyStatistic : BaseStatistic
    {
        public WordFrequencyStatistic(Dictionary<string, int> items)
        {
            Items = new ReadOnlyCollection<WordFrequency>(
                items.Select(x => new WordFrequency(x.Key, x.Value)).ToList());
        }

        // если статистика меняться не будет и не будет часто использоваться поиск по ключу - лучше хранить неизменяемым списком
        
        public ReadOnlyCollection<WordFrequency> Items { get; protected set; }
    }
}
