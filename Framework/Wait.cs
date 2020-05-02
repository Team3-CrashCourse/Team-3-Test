using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Team_3_Test.Framework
{
    public static class Wait
    {
        public static bool WaitFor(Func <bool> func, int millisecondsTimeout = 2000, int waitInterval = 60)
        {
            DateTime start = DateTime.Now;
            do
            {
                if (func())
                    return true;
                Thread.Sleep(waitInterval);
            }
            while (DateTime.Now - start < TimeSpan.FromMilliseconds(millisecondsTimeout));

            return false;
        }
    }
}
