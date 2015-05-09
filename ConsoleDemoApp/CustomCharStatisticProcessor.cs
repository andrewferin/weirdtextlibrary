using System.IO;
using WeirdTextLibrary.Statistics;
using WeirdTextLibrary.TextProcessors;

namespace ConsoleDemoApp
{
    /// <summary>
    /// Обработчик, подсчитывающий кол-во символов в файле
    /// </summary>
    public class CustomCharStatisticProcessor : BaseTextProcessor
    {
        public override BaseStatistic Process(StreamReader reader)
        {
            reader.BaseStream.Position = 0;

            int charCount = 0;
            string currentString = string.Empty;

            // 
            while ((currentString = reader.ReadLine()) != null)
            {
                charCount += currentString.Length;
            }

            return new CustomCharStatistic(charCount);
        }
    }
}
