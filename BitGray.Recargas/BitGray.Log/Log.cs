using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitGray.Log
{
    public class Log
    {
        /// <summary>
        /// Método para ingresar al Log de transacciones.
        /// </summary>
        /// <param name="ex"></param>
        public void InsertLog(Exception ex)
        {
            LogEntry logEntry = new LogEntry();
            logEntry.Message = ex.ToString();
            Logger.Write(logEntry);
        }

        public void InsertLog(string data)
        {
            LogEntry logEntry = new LogEntry();
            logEntry.Message = data;
            Logger.Write(logEntry);
        }
    }
}
