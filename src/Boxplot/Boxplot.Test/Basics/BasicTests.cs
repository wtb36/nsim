using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boxplot.Contract;
using NUnit.Framework;

namespace Boxplot.Test.Basics
{
    public class BasicTests
    {
        public void AscendingOrderOfElements(IBoxplot sut)
        {
            if (sut != null)
            {
                Assert.That(sut.Min, Is.LessThanOrEqualTo(sut.LowerQuartile), "Min <= LowerQuartile.");
                Assert.That(sut.LowerQuartile, Is.LessThanOrEqualTo(sut.Median), "LowerQuartile <= Median.");
                Assert.That(sut.Median, Is.LessThanOrEqualTo(sut.UpperQuartile), "Median <= UpperQuartile.");
                Assert.That(sut.UpperQuartile, Is.LessThanOrEqualTo(sut.Max), "UpperQuartile <= Max.");
            }
        }
    }
}
