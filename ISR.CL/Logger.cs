using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ISR.CL {
    public static class Logger {
        private static string logFilePath = @"..\..\..\ISR_Log_File.csv";

        public static Task Log(string logMessage) {
            if (!File.Exists(logFilePath)) {
                File.AppendAllText(logFilePath, "amount,monthly,ISR calculated\n");
            }
            File.AppendAllText(logFilePath,$"{logMessage}\n");
            return Task.CompletedTask;
        }
    }
}
