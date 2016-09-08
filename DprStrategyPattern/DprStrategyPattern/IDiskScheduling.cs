using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprStrategyPattern
{
    public interface IDiskScheduling
    {
        /// <summary>
        /// ReadRequest process incoming request from a list with the a current request and returns nextRequest
        /// </summary>
        /// <param name="requests">List of request</param>
        /// <param name="requests>current request; used to determine next reading request</param>
        /// <returns>nextRequest based on strategy and current request</returns>
        Request ReadRequest(List<Request> requests, Request request);

    }
}
