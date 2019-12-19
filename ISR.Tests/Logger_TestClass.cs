using Microsoft.VisualStudio.TestTools.UnitTesting;
using ISR.CL;
using System.IO;

namespace ISR.Tests {
    [TestClass]
    public class Logger_TestClass {
        [TestMethod]
        public void Log_Message_Check_Log_File_Existence() {
            Logger.Log($"25000,true,300");
            Assert.IsTrue(File.Exists(@"..\..\..\ISR_Log_File.csv"));
        }
        [TestMethod]
        public void Log_Message_Check_Log_Message_Was_Saved() {
            if (File.Exists(@"..\..\..\ISR_Log_File.csv")) {
                File.Delete(@"..\..\..\ISR_Log_File.csv");
            }
            Logger.Log("25000,true,300");
            int rowCount = File.ReadAllLines(@"..\..\..\ISR_Log_File.csv").Length;
            Assert.AreEqual(rowCount, 2);
            File.Delete(@"..\..\..\ISR_Log_File.csv");
        }
    }
}
