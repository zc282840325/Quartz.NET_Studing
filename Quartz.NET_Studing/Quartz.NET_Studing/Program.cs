using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Quartz.NET_Studing
{
    class Program
    {
        static void Main(string[] args)
        {
            string CronTime = "0/1 * * * * ?";//每一秒执行一次
            string CronTime2 = "0 39 23 ? * *";//每天早上0：10分执行
            
            QuartzUtil.AddJob<HelloJob>("job1", CronTime2);
            QuartzUtil.AddJob<TimerJob>("job2", CronTime);
        }
    }
}
