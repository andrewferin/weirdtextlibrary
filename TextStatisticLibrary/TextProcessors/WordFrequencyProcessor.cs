using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextStatisticLibrary.Statistics;

namespace TextStatisticLibrary.TextProcessors
{
    public class WordFrequencyProcessor : BaseTextProcessor
    {
        private readonly char[] SplitArray = new char[] { ' ', '\t' };

        public override BaseStatistic Process(StreamReader reader)
        {
            var result = new Dictionary<string, int>();

            // move to begin
            reader.BaseStream.Position = 0;

            // reading
            string currentString = null;
            while ((currentString = reader.ReadLine()) != null)
            {
                string[] arr = currentString.Split(this.SplitArray, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < arr.Length; i++)
                    result[arr[i]] = result.ContainsKey(arr[i]) ? result[arr[i]] + 1 : 1;
            }

            return new WordFrequencyStatistic(result);
        }
    }
}
