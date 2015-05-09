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
        public override void Write(BaseStatistic statistic)
        {
            // проверим тип
            WordCountStatistic result = statistic as WordCountStatistic;
            if (result == null)
                throw new Exception(ErrorMessages.WriterInvalidStatisticsResult);

            // вывод
            Console.WriteLine("Words total: {0}", result.Count);
        }
    }
}
