using System;
using WeirdTextLibrary.Constants;
using WeirdTextLibrary.Statistics;

namespace WeirdTextLibrary.StatisticWriters
{
    /// <summary>
    /// Интерфейс для записи статистики по количеству слов в консоль
    /// </summary>
    public class WordCountConsoleWriter : BaseStatisticWriter
    {
        public override void Write(BaseStatistic baseResult)
        {
            // проверим тип
            WordCountStatistic result = baseResult as WordCountStatistic;
            if (result == null)
                throw new Exception(ErrorMessages.WriterInvalidStatisticsResult);

            // вывод
            Console.WriteLine("Words count:\n{0}", result.Count);
        }
    }
}
