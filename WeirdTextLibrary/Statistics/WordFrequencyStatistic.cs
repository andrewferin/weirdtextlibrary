using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeirdTextLibrary.Statistics
{
    /// <summary>
    /// Статистика частоты слов
    /// </summary>
    public class WordFrequencyStatistic : BaseStatistic
    {
        public WordFrequencyStatistic(Dictionary<string, int> items) { Items = items; }

        public Dictionary<string, int> Items { get; protected set; }
    }
}
