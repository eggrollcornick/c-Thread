using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FrmBasicThreadManalo
{
    class MyThreadClass
    {
        public static void Thread1()
        {
            for (int loopers = 0; loopers<6; loopers++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopers);
                Thread.Sleep(1500);
            }
        }
    }
}
