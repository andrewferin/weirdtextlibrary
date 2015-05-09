using System;
using System.IO;
using WeirdTextLibrary.Checkers.Files;
using WeirdTextLibrary.Statistics;
using WeirdTextLibrary.StatisticWriters;
using WeirdTextLibrary.TextProcessors;

namespace ConsoleDemoApp
{
    class Program
    {
        /// <summary>
        /// Метод проверки имени файла
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static bool FileNameIsNotValid(string fileName)
        {
            string error = string.Empty;
            if ((error = new FileNameChecker().Check(fileName)).Length != 0)
                Console.WriteLine("Errors:\n\"{0}\" - {1}", fileName, error);

            return error.Length != 0;
        }

        /// <summary>
        /// Метод обработки файла
        /// </summary>
        /// <param name="fileName"></param>
        static void ProcessFile(string inputFileName, string outputFileName)
        {
            if (FileNameIsNotValid(inputFileName) ||
                FileNameIsNotValid(outputFileName))
            {
                return;
            }

            // обработки файла
            BaseStatistic frequencyStatistic = null;
            using (StreamReader reader = new StreamReader(inputFileName))
            {
                frequencyStatistic = new WordFrequencyProcessor().Process(reader);
            }

            // вывод в результирующий файл
            using (StreamWriter writer = new StreamWriter(outputFileName))
            {
                BaseStatisticWriter statisticWriter = new WordFrequencyStreamWriter(writer);
                statisticWriter.Write(frequencyStatistic);
            }

            Console.WriteLine("Обработка завершена");
        }

        static void Main(string[] args)
        {
            // если есть аргументы командной строки - предполагаем, что там имена файлов
            ProcessFile(
                args.Length > 0 ? args[0] : "TestInputFile.txt",    // первый - имя файла ввода
                args.Length > 1 ? args[1] : "TestOutputFile.txt");  // второй - вывода

            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
