using System;
using System.IO;
using WeirdTextLibrary.Statistics;
using WeirdTextLibrary.StatisticWriters;

namespace ConsoleDemoApp
{
    /// <summary>
    /// Вывод результатов статистики по количеству символов в консоль
    /// </summary>
    public class CustomCharStatisticStreamWriter : BaseStatisticStreamWriter
    {
        public CustomCharStatisticStreamWriter(StreamWriter writer) : base(writer) { }

        public override void Write(BaseStatistic statistics)
        {
            CustomCharStatistic output = statistics as CustomCharStatistic;
            if (output == null)
                throw new Exception(WeirdTextLibrary.Constants.ErrorMessages.WriterInvalidStatistic);

            this.Writer.WriteLine("Chars total: {0}", output.Count);
        }
    }
}
