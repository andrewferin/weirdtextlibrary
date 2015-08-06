using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeirdTextLibrary.Constants;
using WeirdTextLibrary.Statistics;

namespace WeirdTextLibrary.StatisticWriters
{
    /// <summary>
    /// Интерфейс для записи статистики по частоте слов в консоль
    /// </summary>
    public class WordFrequencyConsoleWriter : BaseStatisticConsoleWriter
    {
        public override void Write(BaseStatistic statistic)
        {
            // проверим тип статистики
            WordFrequencyStatistic result = statistic as WordFrequencyStatistic;
            if (result == null)
                throw new Exception(ErrorMessages.WriterInvalidStatistic);

            foreach (var i in result.Items)
                Console.WriteLine("{0} = {1}", i.Word, i.Frequency);
        }
    }
}
