using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DprObserverPattern;

namespace DprObserverPatternTest
{
    [TestClass]
    public class StormTest
    {
        private static WeatherAlertSubject subject;
        private static WeatherAlertOberserver observer;

        [TestInitialize]
        public void Setup()
        {
            subject = new WeatherAlertSubject();
        }

        [TestMethod]
        public void StormSubject_Attach()
        {
            //Setup
            Setup();
            
            //Arrange|Act
            observer = new WeatherAlertOberserver(subject);

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
            WeatherAlerData data = new WeatherAlerData
            {
                IsWeatherAlert = true,
                Severity = "High"
            };

            //Act
            subject.WeatherAlerData = data;

            //Assert
            Assert.AreEqual(subject.WeatherAlerData, observer.WeatherAlerDataUi);
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
