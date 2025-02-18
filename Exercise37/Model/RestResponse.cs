using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise37.Model
{
    public class RestResponse
    {
        private int statusCode;
        private string? responseData;

        public RestResponse(int statusCode, string? responseData)
        {
            this.statusCode = statusCode;
            this.responseData = responseData;
        }

        public int StatusCode
        {
            get
            {
                return statusCode;
            }

        }

        public string ResponseData
        {
            get
            {
                return responseData!;
            }
        }

        public override string ToString()
        {
            return $"StatusCode: {StatusCode}  ResponseData: {ResponseData}";
        }
    }
}