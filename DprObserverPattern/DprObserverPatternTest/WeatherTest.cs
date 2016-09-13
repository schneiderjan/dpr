using System;
using System.Threading.Tasks;
using DprObserverPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenWeatherMap;

namespace DprObserverPatternTest
{
    [TestClass]
    public class WeatherTest
    {
        private static WeatherSubject subject;
        private static WeatherObserver observer;
        private static OpenWeatherMapClient weatherMapClient;

        [TestInitialize]
        public void Setup()
        {
            subject = new WeatherSubject();
            weatherMapClient = new OpenWeatherMapClient("c29ea3be75bc79b4fd54b5ea53cdd6aa");
        }

        [TestMethod]
        public void WeatherSubject_Attach()
        {
            //Setup
            Setup();

            //Arrange|Act
            observer = new WeatherObserver(subject);

            //Assert
            Assert.AreEqual(1, subject.Observers.Count);
            Assert.AreEqual(observer, subject.Observers[0]);

        }

        [TestMethod]
        public void WeatherSubject_Notify()
        {
            //Setup
            WeatherSubject_Attach();

            //Arrange
            CurrentWeatherResponse data=null;
            Task.Run(async () => {
                data = await weatherMapClient.CurrentWeather.GetByName("Eindhoven");
            });

            //Act
            subject.WeatherData = data;

            //Assert
            Assert.AreEqual(subject.WeatherData, observer.WeatherDataUi);
        }

        [TestMethod]
        public void WeatherSubject_Detach()
        {
            //Setup
            WeatherSubject_Attach();

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
            weatherMapClient = null;
            subject = null;
            observer = null;
        }
    }
}
