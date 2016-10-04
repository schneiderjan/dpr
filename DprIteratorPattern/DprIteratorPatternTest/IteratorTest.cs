using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DprIteratorPattern;
using System.Collections.Generic;

namespace DprIteratorPatternTest
{
    [TestClass]
    public class IteratorTest
    {
        private static DprIteratorPattern.Channel[] expected;


        [TestMethod]
        public void IteratorValuesValid_Test()
        {
            //Arrange
            expected = new Channel[] {
                new Channel("ARD"),
                new Channel("ZDF"),
                new Channel("WDR"),
                new Channel("TVR"),
                new Channel("PRO TV"),
                new Channel("DIGI Sport"),
                new Channel("Dolce Sport"),
                new Channel("SPORT1"),
                new Channel("Acasa TV")
            };

            DprIteratorPattern.ChannelRepository repo = new DprIteratorPattern.ChannelRepository();
            List<Channel> actual = new List<Channel>();
            var iter = repo.GetIterator();

            //Act
            while (iter.HasNext())
            {
                var iterated = (Channel)iter.Next();
                actual.Add(iterated);
            }

            //Assert
            var test = actual.ToArray();
            CollectionAssert.AreEqual(expected, test, new ChannelComparer());
        }
    }
}



