using System;
using System.Collections.Generic;
using AC.Interfaces;

namespace AC.Commons
{
    public static class LogMaster
    {
        public static void LogInput(List<ILogger> data)
        {
            // Do something with the data.
            foreach (var item in data)
            {
                item.Log();
            }
        }
    }
}