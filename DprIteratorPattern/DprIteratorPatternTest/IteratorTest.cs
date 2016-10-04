using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DprIteratorPattern;
using System.Collections.Generic;

namespace DprIteratorPatternTest
{
    [TestClass]
    public class IteratorTest
    {
        [TestMethod]
        public void IteratorValuesValid_Test()
        {
            //Arrange
            List<string> expected = new List<string> { "One", "Two", "Three", "Li", "Li" };
            ChannelRepository repo = new ChannelRepository();
            List<string> actual = new List<string>();

            //Act
            for (var iter = repo.GetIterator(); iter.HasNext();)
            {
                var iterated = (string)iter.Next();
                actual.Add(iterated);
            }

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
