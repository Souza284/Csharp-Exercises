using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise37.GetEndPoint
{
    public class TestGetEndPoint
    {
        private string getUrl = "https://pokeapi.co/api/v2/pokemon/";
        public void TestGetAllEndPoint()
        {
            //Step 1: Create the HTTP Client instance(object)
            HttpClient httpClient = new();

            //Step 2 & 3: Create the request and execute it
            httpClient.GetAsync(getUrl);

            //Close the connection
            httpClient.Dispose();
        }

        public void TestGetAllEndPointWithUri()
        {
            HttpClient httpClient = new();

            Uri getUri = new(getUrl);

            Task<HttpResponseMessage> httpResponse = httpClient.GetAsync(getUri);

            HttpResponseMessage httpResponseMessage = httpResponse.Result;

            Console.WriteLine(httpResponseMessage.ToString());

            httpClient.Dispose();
        }
    }
}