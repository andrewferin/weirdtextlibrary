﻿using System;
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

            foreach (var i in result.Items)
                this.Writer.WriteLine("{0} = {1}", i.Word, i.Frequency);
        }
    }
}
