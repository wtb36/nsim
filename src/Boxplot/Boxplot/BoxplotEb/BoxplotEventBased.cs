using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boxplot.Contract;

namespace Boxplot.BoxplotEb
{
    public class BoxplotEventBased : IBoxPlotCreator
    {
        public void CreateBoxplot(EbcFramework.RequestWithResponsePin<IEnumerable<double>, IBoxplot> Request)
        {
            IBoxplot bp;
            if (Request.RequestData == null)
            {
                Request.ResponsePin(null);
                return;
            }

            double[] dataSorted = Request.RequestData.OrderBy(t => t).ToArray();
            int len = dataSorted.Length;
            // Empty data.
            if (len <= 0)
            {
                Request.ResponsePin(null);
                return;
            }

            // Degenerated case: len == 1.
            if (len == 1)
            {
                bp = new cBoxplot()
                {
                    Min = dataSorted[0],
                    LowerQuartile = dataSorted[0],
                    Median = dataSorted[0],
                    UpperQuartile = dataSorted[0],
                    Max = dataSorted[0]
                };
            }
            else
            {
                bp = new cBoxplot()
                {
                    Min = dataSorted[0],
                    Median = (len % 2 == 0)
                    ? 0.5 * (dataSorted[len / 2] + dataSorted[len / 2 - 1])
                    : dataSorted[(len - 1) / 2],
                    Max = dataSorted[len - 1]
                };
            }
            Request.ResponsePin(bp);
        }
    }
}
