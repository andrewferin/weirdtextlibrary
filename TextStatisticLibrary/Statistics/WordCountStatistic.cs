using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatisticLibrary.Statistics
{
    /// <summary>
    /// Статистика по количесту слов
    /// </summary>
    public class WordCountStatistic : BaseStatistic
    {
        public WordCountStatistic(int count) { Count = count; }
        
        public int Count { get; protected set; }
    }
}
