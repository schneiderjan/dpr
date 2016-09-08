using System.Collections.Generic;
using System.Linq;

namespace DprStrategyPattern
{
    //All incoming requests are placed at the end of the queue.
    //Hence first index of the list can be returned.
    public class FifoScheduling : IDiskScheduling
    {
        public Request ReadRequest(List<Request> requests, Request request)
        {
            //The next request is the first in the updated list.
            var nextProcess = requests.FirstOrDefault();

            //Update the next request.
            if (nextProcess != null)
            {
                nextProcess.Previous = request.Current;
            }

            return nextProcess;
        }
    }
}
