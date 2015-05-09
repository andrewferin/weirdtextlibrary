using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeirdTextLibrary.Statistics;

namespace WeirdTextLibrary.TextProcessors
{
    /// <summary>
    /// Обработчик для получения статистики по словам из потока
    /// </summary>
    public class WordFrequencyProcessor : BaseTextProcessor
    {
        /// <summary>
        /// Внутренний класс для проверки 
        /// </summary>
        private static class WordChecker
        {
            public static bool IsWord(string s)
            {
                // строку считаем словом, когда она не пуста и начинается с буквы
                return s.Length > 0 && Char.IsLetter(s[0]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private readonly char[] SplitArray = new char[] { ' ', '\t' };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader">Входной поток</param>
        /// <returns>Объект WordFrequencyStatistic</returns>
        public override BaseStatistic Process(StreamReader reader)
        {
            var result = new Dictionary<string, int>();

            // Двигаемся в начало файла
            reader.BaseStream.Position = 0;

            // Чтение
            string currentString = null;
            while ((currentString = reader.ReadLine()) != null)
            {
                string[] arr = currentString.Split(this.SplitArray, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < arr.Length; i++)
                {
                    if (WordChecker.IsWord(arr[i]))
                        result[arr[i]] = result.ContainsKey(arr[i]) ? result[arr[i]] + 1 : 1;
                }
            }

            return new WordFrequencyStatistic(result);
        }
    }
}
