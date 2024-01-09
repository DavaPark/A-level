using System;

namespace homework5
{

    public class Logger
    {
        private Result[] _logs = new Result[15];
        private int _counter = 0;

        public string LogLevel { get; set; } = "Info";

        public void PrintLog()
        {
            for (int i = 0; i < _logs.Length; i++)
            {
                if (_logs[i].Status == LogLevel)
                {
                    Console.WriteLine($"{_logs[i].DateTime}: {_logs[i].Status}: {_logs[i].Messege}");
                }
                else if (LogLevel == "All")
                {
                    Console.WriteLine($"{_logs[i].DateTime}: {_logs[i].Status}: {_logs[i].Messege}");
                }
            }
        }

        public void AddLog(Result log)
        {
            _logs[_counter] = log;
            _counter++;
        }
    }
}