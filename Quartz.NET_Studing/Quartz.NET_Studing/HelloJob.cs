using Common.Logging;
using System;

namespace Quartz.NET_Studing
{
    internal class HelloJob: IJob
    {
        private readonly ILog _logger = LogManager.GetLogger(typeof(HelloJob));

        void IJob.Execute(IJobExecutionContext context)
        {
            _logger.InfoFormat("TestJob测试");
            Console.WriteLine("Greetings from HelloJob!");
        }
    }
}