using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UATP_Practice.PATTERNS
{
    // ----------------------------------------------------------------------------------------------------------------------------------
    //Let's say you have an application that needs to fetch data from an external API, but you want to add some additional functionality,
    //such as caching the results or logging the requests. In this case, you can use the Proxy Pattern to create a proxy class that wraps
    //around the actual API client and provides the additional functionality.
    // ----------------------------------------------------------------------------------------------------------------------------------

    // ------------------------------------------------------------------------------------
    // First, define an interface that represents the functionality of the API client:
    // ------------------------------------------------------------------------------------

    public interface IApiClient
    {
        string GetData();
    }

    // ------------------------------------------------------------------------------------
    // Next, implement the actual API client:
    // ------------------------------------------------------------------------------------

    public class ApiClient : IApiClient
    {
        public string GetData()
        {
            // Code to fetch data from the external API
            return "Data from external API";
        }
    }

    // ------------------------------------------------------------------------------------
    // Now, create a proxy class that implements the same interface:
    // ------------------------------------------------------------------------------------

    public class ApiProxy : IApiClient
    {
        private readonly IApiClient _apiClient;

        public ApiProxy()
        {
            _apiClient = new ApiClient();
        }

        public string GetData()
        {
            // Additional functionality before delegating the call to the actual API client
            Console.WriteLine("Logging the API request");

            // Delegate the call to the actual API client
            string data = _apiClient.GetData();

            // Additional functionality after receiving the data
            Console.WriteLine("Caching the API response");

            return data;
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    //The key idea is that the proxy class provides a way to add additional functionality to the original object without modifying its code directly.
    // ----------------------------------------------------------------------------------------------------------------------------------
}
