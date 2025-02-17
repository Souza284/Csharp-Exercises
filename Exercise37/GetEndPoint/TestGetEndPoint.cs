using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Exercise37.GetEndPoint
{
    public class TestGetEndPoint
    {
        private static string getUrl = "https://pokeapi.co/api/v2/pokemon/";
        public static void TestGetAllEndPoint()
        {
            //Step 1: Create the HTTP Client instance(object)
            HttpClient httpClient = new();

            //Step 2 & 3: Create the request and execute it
            httpClient.GetAsync(getUrl);

            //Close the connection
            httpClient.Dispose();
        }

        public static void TestGetAllEndPointWithUri()
        {
            //Step 1: Create the HTTP Client instance(object)
            HttpClient httpClient = new();
            
            //Step 2 & 3: Create the request and execute it
            Uri getUri = new(getUrl);
            Task<HttpResponseMessage> httpResponse = httpClient.GetAsync(getUri);
            HttpResponseMessage httpResponseMessage = httpResponse.Result;
            //Console.WriteLine(httpResponseMessage.ToString());

            //Status
            HttpStatusCode httpStatusCode = httpResponseMessage.StatusCode;
            //Console.WriteLine("Status code: " + httpStatusCode);

            //Response Data
            HttpContent httpContent = httpResponseMessage.Content;
            Task<string> responseData = httpContent.ReadAsStringAsync();
            string data = responseData.Result;
            Console.WriteLine(data);

            httpClient.Dispose();
        }
    }
}