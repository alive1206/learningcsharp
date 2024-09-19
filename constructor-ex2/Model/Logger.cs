namespace LogData
{
    public class Logger
    {
        public string LogData {get;set;}
        static Logger _log;

        private Logger()
        {
            LogData = "";
        }

        public static Logger GetInstance()
        {
            if(_log == null)
            {
                _log = new Logger();
            }
            return _log;
        }

        public void Log(string message)
        {
            LogData += $"Message: {message}\n";
        }

        public void PrintLog()
        {
            Console.WriteLine(LogData);
        }  
    
    }
}