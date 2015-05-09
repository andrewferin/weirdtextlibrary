using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextStatisticLibrary.Statistics;

namespace TextStatisticLibrary.TextProcessors
{
    /// <summary>
    /// Абстрактный интерфейс для обработки текстового файла
    /// </summary>
    public abstract class BaseTextProcessor
    {
        protected BaseTextProcessor() 
        {

        }

        public abstract BaseStatistic Process(StreamReader reader);
    }
}
