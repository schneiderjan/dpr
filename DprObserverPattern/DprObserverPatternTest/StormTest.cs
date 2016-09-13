using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DprObserverPattern;

namespace DprObserverPatternTest
{
    [TestClass]
    public class StormTest
    {
        private static StormSubject subject;
        private static StormOberserver observer;

        [TestInitialize]
        public void Setup()
        {
            subject = new StormSubject();
        }

        [TestMethod]
        public void StormSubject_Attach()
        {
            //Setup
            Setup();
            
            //Arrange|Act
            observer = new StormOberserver(subject);

            //Assert
            Assert.AreEqual(1, subject.Observers.Count);
            Assert.AreEqual(observer, subject.Observers[0]);
        }

        [TestMethod]
        public void StormSubject_Notify()
        {
            //Setup
            StormSubject_Attach();

            //Arrange
            StormData data = new StormData
            {
                IsStormAlert = true,
                Severity = "High"
            };

            //Act
            subject.StormData = data;

            //Assert
            Assert.AreEqual(subject.StormData, observer.StormDataUi);
        }

        [TestMethod]
        public void StormSubject_Detach()
        {
            //Setup
            StormSubject_Attach();

            //Act
            subject.Detach(observer);

            //Assert
            Assert.AreEqual(0, subject.Observers.Count);

            //TearDown
            TearDown();
        }
        [TestCleanup]
        public void TearDown()
        {
            subject = null;
            observer = null;
        }
    }
}
