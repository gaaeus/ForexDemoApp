using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForexDemoApp.Enumerations
{
    public static class Interval
    {
        public const string
            _1min = "1min",
            _5min = "5min",
            _15min = "15min",
            _30min = "30min",
            _60min = "60min"
            ;
    }

    public static class Outputsize
    {
        public const string
            compact = "compact",
            full = "full"
            ;
    }

    public static class DataType
    {
        public const string
            json = "json",
            csv = "csv"
            ;
    }
}
