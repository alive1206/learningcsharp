using LogData;

class Program
{
    static void Main(string[] args)
    {
       
        Logger logger = Logger.GetInstance();     
        
    
        logger.Log("Test Log 1");
        logger.Log("Test Log 2");
        logger.Log("Test Log 3");
 
        logger.PrintLog();
    }
}

