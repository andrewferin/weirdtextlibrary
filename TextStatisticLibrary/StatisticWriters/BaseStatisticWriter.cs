using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextStatisticLibrary.Statistics;

namespace TextStatisticLibrary.StatisticWriters
{
    public abstract class BaseStatisticWriter
    {
        public abstract void Write(WordCountStatistic statistic);
        public abstract void Write(WordFrequencyStatistic statistic);
    }
}
