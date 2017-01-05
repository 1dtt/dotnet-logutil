using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogUtil;

namespace HostProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            LogUtil.FileLogger.Configure();

            FileLogger.Error("OK", new Exception("asdasd111"));
            Console.ReadKey();
        }
    }
}
