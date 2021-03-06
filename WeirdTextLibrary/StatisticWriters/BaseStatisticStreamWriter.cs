﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeirdTextLibrary.Statistics;

namespace WeirdTextLibrary.StatisticWriters
{
    /// <summary>
    /// Интерфейс для записи статистики в поток
    /// </summary>
    public class BaseStatisticStreamWriter : BaseStatisticWriter
    {
        /// <summary>
        /// Поток для записи
        /// </summary>
        protected readonly StreamWriter Writer;

        public BaseStatisticStreamWriter(StreamWriter writer)
        {
            Writer = writer;
        }

        /// <summary>
        /// Данный метод не должен быть использован
        /// </summary>
        /// <param name="statistic"></param>
        public override void Write(BaseStatistic statistic)
        {
            throw new NotImplementedException();
        }
    }
}
