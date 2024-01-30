using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10Calculator
{
    public class FileLogger : ILoggable
    {
        public void Log(string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(_fileName, true))
            {
                streamWriter.WriteLine(DateTime.Now+" " +message);
            }
        }
        private string _fileName;
        public FileLogger(string filename = "log.txt")
        {
            _fileName = filename;
        }
    }
}
