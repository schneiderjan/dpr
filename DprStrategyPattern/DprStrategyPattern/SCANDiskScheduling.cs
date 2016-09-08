using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DprStrategyPattern
{
    //The SCAN disk scheduling ('elevator') approach scans requests in one direction until it reaches the end of the list than goes back to the other eand and process the left requests in opposite direction.
    //This methods depends on the previous request to determine the direction of the 'elevator'.
    public class ScanDiskScheduling : IDiskScheduling
    {
        public Request ReadRequest(List<Request> requests, Request request)
        {
            //Sort the list ascending
            requests = SortList(requests, 1);

            //finds the next greatest number in the list or null
            var nextRequest = requests.SkipWhile(p => p.Current <= request.Current).FirstOrDefault();
            if (nextRequest != null)
            {
                nextRequest.Previous = request.Current;
            }
            //if null take the biggest remaining item in the list
            else
            {
                if (requests.Count == 0)
                {
                    nextRequest = null;
                }
                else
                {
                    try
                    {
                        //finds the largest item in the list. since list is sorted Last() returns the greatest
                        nextRequest = requests.TakeWhile(p => p.Current < request.Current).Last();
                        nextRequest.Previous = request.Current;
                    }
                    catch (InvalidOperationException)
                    {
                        nextRequest = request;
                    }
                }
            }
            return nextRequest;
        }


        /// <summary>
        /// Sorts the list by current value
        /// </summary>
        /// <param name="requests">list of requests</param>
        /// <param name="sortDirection">1 = sort asc; -1 = sort desc</param>
        /// <returns>sorted list</returns>
        private List<Request> SortList(List<Request> requests, int sortDirection)
        {
            var t = Task.Run(() =>
            {
                if (sortDirection > 0) requests = requests.OrderBy(o => o.Current).ToList();
                else if (sortDirection < 0) requests = requests.OrderByDescending(o => o.Current).ToList();
            });
            t.Wait(TimeSpan.FromSeconds(5));
            return requests;
        }

    }
}
