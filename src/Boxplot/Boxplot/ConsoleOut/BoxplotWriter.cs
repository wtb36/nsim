using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boxplot.Contract;

namespace Boxplot.ConsoleOut
{
    public class BoxplotWriter
    {
        public void WriteBoxplot(IBoxplot Boxplot)
        {
            Console.WriteLine("Maximum: {0}", Boxplot.Max);
            Console.WriteLine("UpperQuartile: {0}", Boxplot.UpperQuartile);
            Console.WriteLine("Median: {0}", Boxplot.Median);
            Console.WriteLine("LowerQuartile: {0}", Boxplot.LowerQuartile);
            Console.WriteLine("Minimum: {0}", Boxplot.Min);
        }
    }
}
