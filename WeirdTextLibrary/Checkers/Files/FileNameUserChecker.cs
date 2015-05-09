using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeirdTextLibrary.Checkers.Files
{
    public class FileNameChecker
    {
        /// <summary>
        /// Внутренние ошибки
        /// </summary>
        protected static class ErrorMessages
        {
            public static string InvalidFileName = "Некорректное имя файла";
            public static string InvalidFileNameLength = "Имя файла пусто";
            public static string InvalidFileNameCharacters = "Некорректное имя файла";
        }

        public virtual string Check(string fileName)
        {
            if (fileName.Length <= 0)
                return ErrorMessages.InvalidFileNameLength;

            if (fileName.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()) != -1)
                return ErrorMessages.InvalidFileNameCharacters;

            return string.Empty;
        }
    }
}
