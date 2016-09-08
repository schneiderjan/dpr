using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DprStrategyPattern;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace DprStrategyPatternTest
{

    [TestClass]
    public class FifoSchedulingTest
    {
        private static FifoScheduling _fifo;
        private static List<Request> _requests, _expectedreRequestss, _actualRequests;
        private static Request _currentProcess;

        [TestInitialize]
        public void Setup()
        {
            //create hardcoded list of requests and initialize classes and lists
            _fifo = new FifoScheduling();
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
        public void FifoScheduling_Test()
        {
            //setup 
            Setup();

            //Arrange
            //for convenience select first item as CurrentRequest
            #region expectedProcesses

            _expectedreRequestss = new List<Request>
            {
                 new Request
                {
                    Current = 5,
                    Previous = -1
                },
                new Request
                {
                    Current = 90,
                    Previous = 5
                },
                new Request
                {
                    Current = 49,
                    Previous = 90
                },
                new Request
                {
                    Current = 69,
                    Previous = 49
                },
                new Request
                {
                    Current = 25,
                    Previous = 69
                }
            };


            #endregion
            _currentProcess = _requests[0];

            //Act
            //loop through the list and call strategy.
            for (int i = 0; i <= 4; i++)
            {
                _actualRequests.Add(_currentProcess);
                _requests.Remove(_currentProcess);
                var nextRequest = _fifo.ReadRequest(_requests, _currentProcess);
                _currentProcess = nextRequest;
            }

            //Assert
            CollectionAssert.AreEqual(_expectedreRequestss, _actualRequests, new RequestComparer());
            
            //Teardown
            TearDown();
        }

        [TestCleanup]
        public void TearDown()
        {
            _fifo = null;
            _actualRequests = null;
            _requests = null;
            _expectedreRequestss = null;
        }

    }
}
