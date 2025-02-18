using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Exercise37.Model;

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

        public static void TestGetAllEndPointInJsonFormat()
        {
            HttpClient httpClient = new();

            HttpRequestHeaders httpRequestHeader = httpClient.DefaultRequestHeaders;
            httpRequestHeader.Add("Accept", "application/json");
            //httpRequestHeader.Accept.Add()

            Task<HttpResponseMessage> httpResponse = httpClient.GetAsync(getUrl);
            HttpResponseMessage httpResponseMessage = httpResponse.Result;

            HttpStatusCode httpStatusCode = httpResponseMessage.StatusCode;

            HttpContent httpContent = httpResponseMessage.Content;
            Task<string> responseData = httpContent.ReadAsStringAsync();
            string data = responseData.Result;

            httpClient.Dispose();
        }

        public static void TestGetEndPointUsingSendAsync()
        {
            HttpRequestMessage httpRequestMessage = new();
            httpRequestMessage.RequestUri = new Uri(getUrl);
            httpRequestMessage.Method = HttpMethod.Get;
            httpRequestMessage.Headers.Add("Accept", "application/json");

            HttpClient httpClient = new();
            Task<HttpResponseMessage> httpResponseMessage = httpClient.SendAsync(httpRequestMessage);


            HttpResponseMessage httpResponseMessage1 = httpResponseMessage.Result;


            HttpStatusCode httpStatusCode = httpResponseMessage1.StatusCode;

            HttpContent httpContent = httpResponseMessage1.Content;
            Task<string> responseData = httpContent.ReadAsStringAsync();
            string data = responseData.Result;

            httpClient.Dispose();
        }

        public static void TestUsingStatement()
        {
            using (HttpClient httpClient = new())
            {
                using (HttpRequestMessage httpRequestMessage = new())
                {
                    httpRequestMessage.RequestUri = new Uri(getUrl);
                    httpRequestMessage.Method = HttpMethod.Get;
                    httpRequestMessage.Headers.Add("Accept", "application/json");

                    Task<HttpResponseMessage> httpResponseMessage = httpClient.SendAsync(httpRequestMessage);

                    using (HttpResponseMessage httpResponseMessage1 = httpResponseMessage.Result)
                    {
                        HttpStatusCode httpStatusCode = httpResponseMessage1.StatusCode;

                        HttpContent httpContent = httpResponseMessage1.Content;
                        Task<string> responseData = httpContent.ReadAsStringAsync();
                        string data = responseData.Result;

                        RestResponse restResponse = new((int)httpStatusCode, data);
                        Console.WriteLine(restResponse.ToString());
                    }
                }
            }
        }
    }
}