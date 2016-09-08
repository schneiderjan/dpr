using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprStrategyPattern
{
    public class DiskSchedulingContext
    {
        //Strategy
        private readonly IDiskScheduling _diskScheduling;
        //List of Read requests
        public List<Request> Requests { get; set; }
        //current read request which needs to be processed
        public Request CurrentRequest { get; set; }

        /// <summary>
        /// Public constructor
        /// </summary>
        /// <param name="_diskScheduling">The implementation of strategy pattner of IDiskScheduling</param>
        /// <param name="requests">List of disk reading request</param>
        /// <param name="currentRequest">Gives the current request</param>
        public DiskSchedulingContext(IDiskScheduling _diskScheduling, List<Request> requests, Request currentRequest)
        {
            this._diskScheduling = _diskScheduling;
            if (requests.Count == 0) return;

            Requests = requests;
            CurrentRequest = currentRequest;
        }

        /// <summary>
        /// Gets the next read request from the list "Requests" based on strategy
        /// removes the CurrentRequest from the list and assigns nextRequest
        /// </summary>
        /// <returns>null if Requests empty or found nextRequest according to strategy</returns>
        public Request GetNextRequest()
        {
            //for (var i = 0; i < Requests.Count; i++)
            //{
            //    if (Requests[i].Current == CurrentRequest.Current)
            //        Requests.RemoveAt(i);
            //}
            if (Requests.Count == 0)
                return null;
            var nextRequest = _diskScheduling.ReadRequest(Requests, CurrentRequest);
            CurrentRequest = nextRequest;
            return nextRequest;
        }
    }
}
