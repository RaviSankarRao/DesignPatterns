using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Template
{
    public class FileDataLogger : DataLogger
    {
        const string LOG_FILE = "log.txt";

        public override void LogData(string data)
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            path = Path.Combine(path, LOG_FILE);

            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss") + ": " + data);
            sw.Close();
        }
    }
}
