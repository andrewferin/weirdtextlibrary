using ConsoleDemoApp.ConsoleArgumentCheckers;
using ConsoleDemoApp.Constants;
using System;
using System.IO;
using WeirdTextLibrary.Statistics;
using WeirdTextLibrary.StatisticWriters;
using WeirdTextLibrary.TextProcessors;

namespace ConsoleDemoApp
{
    public class CharStatistic : BaseStatistic
    {
        public CharStatistic(int count) { Count = count; }
        
        public int Count { get; protected set; }
    }
    public class CharStatisticProcessor : BaseTextProcessor
    {
        public override BaseStatistic Process(StreamReader reader)
        {
            reader.BaseStream.Position = 0;

            int charCount = 0;
            string currentString = string.Empty;

            while ((currentString = reader.ReadLine()) != null)
            {
                charCount += currentString.Length;
            }

            return new CharStatistic(charCount);
        }
    }
    public class CharStatisticConsoleWriter : BaseStatisticWriter
    {
        public override void Write(BaseStatistic statistics)
        {
            CharStatistic output = statistics as CharStatistic;
            if (output == null)
                throw new Exception(WeirdTextLibrary.Constants.ErrorMessages.WriterInvalidStatisticsResult);

            Console.WriteLine("Chars total: {0}", output.Count);
        }
    }
        
    class Program
    {

        static void ProcessFile(string fileName)
        {
            // проверим его
            string error = string.Empty;
            if ((error = new FileNameChecker().Check(fileName)).Length != 0)
            {
                Console.WriteLine("Errors:\n\"{0}\" - {1}", fileName, ErrorMessages.InvalidFileName);
                return;
            }

            // также можно проверить на существование, кодировку..

            // какие-то обработки файла
            using (StreamReader reader = new StreamReader(fileName))
            {
                new WordFrequencyConsoleWriter().Write(new WordFrequencyProcessor().Process(reader));
                new WordCountConsoleWriter().Write(new WordCountProcessor().Process(reader));
                new CharStatisticConsoleWriter().Write(new CharStatisticProcessor().Process(reader));
            }
        }

        static void Main(string[] args)
        {
            // если есть аргумент командной строки - по-умолчанию считаем, что там имя файла
            ProcessFile(args.Length > 0 ? args[0] : "TestFile.txt");

            Console.ReadKey();
        }
    }
}
