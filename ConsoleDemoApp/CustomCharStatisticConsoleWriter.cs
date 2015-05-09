using System;
using WeirdTextLibrary.Statistics;
using WeirdTextLibrary.StatisticWriters;

namespace ConsoleDemoApp
{
    /// <summary>
    /// Вывод результатов статистики по количеству символов в консоль
    /// </summary>
    public class CustomCharStatisticConsoleWriter : BaseStatisticWriter
    {
        public override void Write(BaseStatistic statistics)
        {
            CustomCharStatistic output = statistics as CustomCharStatistic;
            if (output == null)
                throw new Exception(WeirdTextLibrary.Constants.ErrorMessages.WriterInvalidStatistic);

            Console.WriteLine("Chars total: {0}", output.Count);
        }
    }
}
