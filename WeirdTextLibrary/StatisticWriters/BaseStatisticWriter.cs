using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeirdTextLibrary.Statistics;

namespace WeirdTextLibrary.StatisticWriters
{
    /// <summary>
    /// Абстрактный интерфейс для записи статистики
    /// </summary>
    public abstract class BaseStatisticWriter
    {
        /// <summary>
        /// Запись
        /// </summary>
        /// <param name="baseResult">Статистика</param>
        public abstract void Write(BaseStatistic statistic);
    }
}
