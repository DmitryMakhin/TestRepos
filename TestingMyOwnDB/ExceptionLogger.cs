using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingMyOwnDB
{
    public class ExceptionLogger
    {
        private StringBuilder _errorLog;

        public ExceptionLogger()
        {
            _errorLog = new StringBuilder();
        }

        public void LogException(Exception ex)
        {
            _errorLog.AppendLine(ex.ToString()+"\n");
        }

        public string GetErrorLog()
        {
            return _errorLog.ToString();
        }
    }
}
