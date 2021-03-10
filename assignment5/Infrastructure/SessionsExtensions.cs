using System;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
namespace assignment5.Infrastructure
{
    //converts things to and from json making it easier for us to store and retrieve the carts
    public static class SessionsExtensions
    {
        public static void SetJson (this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T GetJson<T>(this ISession session, string key)
        {
            var sessionData = session.GetString(key);

            return sessionData == null ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
        }
    }
}
