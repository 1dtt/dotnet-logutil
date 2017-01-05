using System;
using log4net;

namespace LogUtil
{
    public class FileLogger
    {
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Configure()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        public static bool Error(object message)
        {
            try
            {
                logger.Error(message + "\n");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Error(object message, Exception ex)
        {
            try
            {
                dynamic log = new
                {
                    message = message,
                    error = ex.ToString() + "\n"
                };
                logger.Error(log);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
