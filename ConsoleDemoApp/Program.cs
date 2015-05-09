using ConsoleDemoApp.ConsoleArgumentCheckers;
using ConsoleDemoApp.Constants;
using System;
using System.IO;
using WeirdTextLibrary.StatisticWriters;
using WeirdTextLibrary.TextProcessors;

namespace ConsoleDemoApp
{
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
