using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DprIteratorPattern;

namespace DprIteratorPattern
{
    /// <summary>
    /// CollectionAssert.AreEqual doesnt properly see if values are equal
    /// Hence this class is needed.
    /// reference: http://softwareonastring.com/357/why-collectionassert-areequal-fails-even-when-both-lists-contain-the-same-items
    /// </summary>
   public class ChannelComparer : Comparer<Channel>
    {
        public override int Compare(Channel x, Channel y) => x.Name.CompareTo(y.Name);
    }
}
