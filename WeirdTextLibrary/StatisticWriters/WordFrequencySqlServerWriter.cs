using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using WeirdTextLibrary.Constants;
using WeirdTextLibrary.Statistics;

namespace WeirdTextLibrary.StatisticWriters
{
    /// <summary>
    /// Интерфейс для записи статистики по частоте слов в консоль
    /// </summary>
    public class WordFrequencySqlServerWriter : BaseStatisticSqlServerWriter
    {
        public WordFrequencySqlServerWriter(SqlConnection connection) : base(connection) { }

        public override void Write(BaseStatistic statistic)
        {
            // проверим тип статистики
            WordFrequencyStatistic result = statistic as WordFrequencyStatistic;
            if (result == null)
                throw new Exception(ErrorMessages.WriterInvalidStatistic);

            foreach (var key in result.Items)
            {
                //
            }
        }
    }
}
