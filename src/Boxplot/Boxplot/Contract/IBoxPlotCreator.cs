using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EbcFramework;

namespace Boxplot.Contract
{
    public interface IBoxPlotCreator
    {
        void CreateBoxplot(RequestWithResponsePin<IEnumerable<double>, IBoxplot> Request);
    }
}
