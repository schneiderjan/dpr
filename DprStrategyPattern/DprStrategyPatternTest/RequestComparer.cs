using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DprStrategyPattern;

namespace DprStrategyPatternTest
{
    /// <summary>
    /// CollectionAssert.AreEqual doesnt properly see if values are equal
    /// Hence this class is needed.
    /// reference: http://softwareonastring.com/357/why-collectionassert-areequal-fails-even-when-both-lists-contain-the-same-items
    /// </summary>
    class RequestComparer : Comparer<Request>
    {
        public override int Compare(Request x, Request y) => x.Current.CompareTo(y.Current);
    }
}
