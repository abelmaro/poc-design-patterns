namespace PoC_Singleton.Logger
{
    public class LoggerI
    {
        private static LoggerI? instance;
        private LoggerI() { }

        public static LoggerI Instance
        {
            get
            {
                return instance ??= new LoggerI();
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }
    }
}