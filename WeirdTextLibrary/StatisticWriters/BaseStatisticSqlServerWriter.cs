using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    public class BaseStatisticSqlServerWriter : BaseStatisticWriter
    {
        /// <summary>
        /// Поток для записи
        /// </summary>
        protected readonly SqlConnection Connection;

        public BaseStatisticSqlServerWriter(SqlConnection connection)
        {
            Connection = connection;
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
