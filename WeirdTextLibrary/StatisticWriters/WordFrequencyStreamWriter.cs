using System;
using System.IO;
using System.Linq;
using WeirdTextLibrary.Constants;
using WeirdTextLibrary.Statistics;

namespace WeirdTextLibrary.StatisticWriters
{
    /// <summary>
    /// Интерфейс для записи статистики по частоте слов в консоль
    /// </summary>
    public class WordFrequencyStreamWriter : BaseStatisticStreamWriter
    {
        public WordFrequencyStreamWriter(StreamWriter writer) : base(writer) { }

        public override void Write(BaseStatistic statistic)
        {
            // проверим тип статистики
            WordFrequencyStatistic result = statistic as WordFrequencyStatistic;
            if (result == null)
                throw new Exception(ErrorMessages.WriterInvalidStatistic);

            // вывод с сортировкой по ключу
            foreach (var key in result.Items.Keys.OrderBy(x => x))
                this.Writer.WriteLine("{0}: {1}", key, result.Items[key]);
        }
    }
}
