using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextStatisticLibrary.Statistics;

namespace TextStatisticLibrary.TextProcessors
{
    public class WordCountProcessor : BaseTextProcessor
    {
        private readonly char[] SplitArray = new char[] { ' ', '\t' };

        public override BaseStatistic Process(StreamReader reader)
        {
            var result = 0;

            // move to begin
            reader.BaseStream.Position = 0;

            // reading
            string currentString = null;
            while ((currentString = reader.ReadLine()) != null)
            {
                result += currentString.Split(this.SplitArray, StringSplitOptions.RemoveEmptyEntries).Length;
            }

            return new WordCountStatistic(result);
        }
    }

}
