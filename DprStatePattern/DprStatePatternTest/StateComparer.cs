using System.Collections.Generic;
using DprStatePattern;

namespace DprStatePatternTest
{
    /// <summary>
    /// CollectionAssert.AreEqual doesnt properly see if values are equal
    /// Hence this class is needed.
    /// reference: http://softwareonastring.com/357/why-collectionassert-areequal-fails-even-when-both-lists-contain-the-same-items
    /// </summary>
    public class StateComparer : Comparer<State>
    {
        public override int Compare(State x, State y) => x.Action.CompareTo(y.Action);
    }

}