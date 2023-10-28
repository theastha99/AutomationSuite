using System;
using AutomationFramework.Utils;
using Microsoft.Extensions.Configuration;
using RestSharp;

namespace AutomationFramework.Tests
{
	public class APITest
	{
        private readonly string baseUrl;
        public APITest()

		{
            var config = new ConfigurationBuilder()
           .AddJsonFile("appconfig.json")
           .Build();

            baseUrl = config["Api:BaseUrl"];
            if (string.IsNullOrEmpty(baseUrl))
            {
                throw new ArgumentNullException("Api:BaseUrl is missing or empty in appsettings.json");
            }
        }
        public void PerformGetRequest()
        {
            var client = new APIClient(baseUrl);

            var request = new RestRequest("endpoint/path", Method.Get);

            // Execute the request and handle the response
            // (code for executing the request remains the same as previous examples)
        }
    }
}

