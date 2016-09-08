using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DprStrategyPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DprStrategyPatternTest
{
    [TestClass]
    public class SstfSchedulingTest
    {
        private static SstfScheduling _sstf;
        private static List<Request> _requests, _expectedRequests, _actualRequests;
        private static Request _currentRequest;

        [TestInitialize]
        public void Setup()
        {
            //create hardcoded list of requests and initialize classes and lists
            _sstf = new SstfScheduling();
            _actualRequests = new List<Request>();

            _requests = new List<Request>
            {
                new Request
                {
                    Current = 5,
                    Previous = -1
                },
                new Request
                {
                    Current = 90,
                    Previous = -1
                },
                new Request
                {
                    Current = 49,
                    Previous = -1
                },
                new Request
                {
                    Current = 69,
                    Previous = -1
                },
                new Request
                {
                    Current = 25,
                    Previous = -1
                }
            };
        }

        [TestMethod]
        public void SstfScheduling_Test()
        {
            //Setup
            Setup();

            //Arrange
            //for convenience select first item as CurrentRequest
            #region expectedProcesse
            _expectedRequests = new List<Request>
            {
                 new Request
                {
                    Current = 5,
                    Previous = -1
                },
                new Request
                {
                    Current = 25,
                    Previous = 5
                },
               
                new Request
                {
                    Current = 49,
                    Previous = 25
                },
                new Request
                {
                    Current = 69,
                    Previous = 49
                },
                 new Request
                {
                    Current = 90,
                    Previous = 69
                }

            };
            #endregion
            _currentRequest = _requests[0];

            //Act
            //loop through the list and call strategy.
            for (int i = 0; i <= 4; i++)
            {
                _actualRequests.Add(_currentRequest);
                _requests.Remove(_currentRequest);
                if (_requests.Count == 0) break;
                var nextRequest = _sstf.ReadRequest(_requests, _currentRequest);
                _currentRequest = nextRequest;
            }

            //Assert
            CollectionAssert.AreEqual(_expectedRequests, _actualRequests, new RequestComparer());

            //TearDown
            TearDown();
        }

        [TestCleanup]
        public void TearDown()
        {
            _sstf = null;
        }
    }
}
