using System;

namespace EasyDiContainerTest
{
    public class Log : ILog
    {
        public int LogLevel { get; set; }
        public void Write(string message)
        {
            Console.WriteLine(this.LogLevel + "=>" + message);
        }
    }
}