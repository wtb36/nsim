using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boxplot.Contract
{
    public interface IBoxplot
    {
        double Min { get; set; }
        double LowerQuartile { get; set; }
        double Median { get; set; }
        double UpperQuartile { get; set; }
        double Max { get; set; }
    }
}
