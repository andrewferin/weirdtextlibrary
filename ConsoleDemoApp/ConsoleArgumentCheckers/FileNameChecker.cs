using ConsoleDemoApp.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.ConsoleArgumentCheckers
{
    public class FileNameChecker
    {
        public string Check(string fileName)
        {
            if (fileName.Length <= 0)
                return Constants.ErrorMessages.InvalidFileNameLength;

            if (fileName.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()) != -1)
                return Constants.ErrorMessages.InvalidFileNameCharacters;

            return string.Empty;
        }
    }
}
