using System;
using Microsoft.AspNetCore.Http;
namespace assignment5.Infrastructure
{
    //allows us to pass urls
    public static class UrlExtensions
    {
        //generates a URL that the browser will be returned to after the cart has been updated
        public static string PathAndQuery(this HttpRequest request) =>
            request.QueryString.HasValue ? $"{request.Path}{request.QueryString}" : request.Path.ToString();
    }
}
