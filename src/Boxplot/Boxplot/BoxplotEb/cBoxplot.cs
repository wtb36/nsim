using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boxplot.Contract;

namespace Boxplot.BoxplotEb
{
    public class cBoxplot : IBoxplot
    {
        public double Min { get; set; }

        public double LowerQuartile { get; set; }

        public double Median { get; set; }

        public double UpperQuartile { get; set; }

        public double Max { get; set; }
    }
}
