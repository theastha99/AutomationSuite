using System;
using RestSharp;
namespace AutomationFramework.Utils
{
	public class APIClient
	{
        private readonly RestClient _client;
        public APIClient(string baseUrl)
		{
            _client = new RestClient(baseUrl);
        }
        public T Execute<T>(RestRequest request) where T : new()
        {
            var response = _client.Execute<T>(request);
            if (response.ErrorException != null)
            {
                throw new ApplicationException($"API request failed : {response.ErrorMessage}", response.ErrorException);
            }
            return response.Data;
        }
    }
}

