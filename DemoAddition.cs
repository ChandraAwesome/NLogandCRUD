using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NloggerDemo
{
    public class DemoAddition
    {
        Nlogger_Start nLog = new Nlogger_Start();  // create an object from the nloggger class
        public  void Addition()
        {
           
            int a = 10;
            int b = 20;
            //Console.WriteLine("Additon of the both numbers"+a + b);
            int c=a+b;
            nLog.LogDebug("Debuging : Addition Method");
            nLog.LogInfo("result" + " "+c);
            Console.WriteLine(c);
        }
    }
}
