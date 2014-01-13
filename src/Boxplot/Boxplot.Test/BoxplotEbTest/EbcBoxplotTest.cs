using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Boxplot.Test.Basics;
using Boxplot.BoxplotEb;
using Boxplot.Contract;
using EbcFramework;

namespace Boxplot.Test.BoxplotEbTest
{
    [TestFixture]
    public class EbcBoxplotTest
    {
        [TestCase(null)]
        [TestCase(new double[] { 1 })]
        [TestCase(new[] { -3.4 })]
        [TestCase(new[] { 1.2, 4, 3.2, 5.6, 7.8, 65.4, 34, 5.3, -4.3, 3.45, -53.6 })]
        public void AscendingOrder(double[] data)
        {
            BasicTests bt = new BasicTests();
            IBoxPlotCreator sut = new BoxplotEventBased();
            sut.CreateBoxplot(new RequestWithResponsePin<IEnumerable<double>, IBoxplot>(data, bt.AscendingOrderOfElements));
        }
    }
}
