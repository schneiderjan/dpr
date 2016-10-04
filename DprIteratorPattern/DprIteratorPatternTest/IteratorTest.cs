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
                new Channel("Acasa TV"),
                new Channel("SPORT1"),
                new Channel("Dolce Sport"),
                new Channel("DIGI Sport"),
                new Channel("PRO TV"),
                new Channel("TVR"),
                new Channel("WDR"),
                new Channel("ZDF"),
                new Channel("ARD"),
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
            while (iter.HasPrevious())
            {
                var iterated = (Channel)iter.Previous();
                actual.Add(iterated);
            }

            //Assert
            var test = actual.ToArray();
            CollectionAssert.AreEqual(expected, test, new ChannelComparer());
        }
    }
}



