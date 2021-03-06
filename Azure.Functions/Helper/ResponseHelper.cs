﻿using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;

namespace FluentChange.Extensions.Azure.Functions.Helper
{
    public static class ResponseHelper
    {
        public static HttpResponseMessage CreateJsonResponse(object response, HttpStatusCode statuscode)
        {
            var json = JsonConvert.SerializeObject(response);
            //return new JsonResult(response,settings); // this is currently not working
            return new HttpResponseMessage(statuscode)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
        }
        public static HttpResponseMessage CreateJsonResponse(object response)
        {
            return CreateJsonResponse(response, HttpStatusCode.OK);
        }
    }
}
