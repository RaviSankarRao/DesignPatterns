using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    class ExceptionHandler
    {
        private static ExceptionHandler _Instance;

        private StreamWriter _StreamWriter;

        public static ExceptionHandler Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new ExceptionHandler();
                }

                return _Instance;
            }
        }

        // Private constructor
        private ExceptionHandler()
        {
            string executablePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            _StreamWriter = new StreamWriter(Path.Combine(executablePath, "exception.txt"));
        }

        public void WriteException(Exception exception)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss"));
            builder.Append(": ");
            builder.Append(exception.Message);

            _StreamWriter.WriteLine(builder.ToString());
            _StreamWriter.Flush();
        }

    }
}
