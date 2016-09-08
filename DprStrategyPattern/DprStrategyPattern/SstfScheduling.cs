using System;
using System.Collections.Generic;
using System.Linq;

namespace DprStrategyPattern
{
    //The SSTF (Shortest Seek Time First) the requests are handled according to the next shortest distance.
    public class SstfScheduling : IDiskScheduling
    {
        public Request ReadRequest(List<Request> requests, Request request)
        {
            //finds the smallest difference between request.Current and other list items
            var nextRequest = requests.Aggregate((x, y) => Math.Abs(x.Current - request.Current) < Math.Abs(y.Current - request.Current) ? x : y);
            nextRequest.Previous = request.Current;

            return nextRequest;
        }
    }
}
           