using System;
using emailvalidation.Helpers;

namespace emailvalidation
{
    public class Emailvalidation
    {
        private string ApiKey { get; }

        public Emailvalidation()
        {
        }

        public Emailvalidation(string apiKey)
        {
            ApiKey = apiKey;
        }

        public string Status()
        {
            return RequestHelper.Status(ApiKey);
        }

        public string Info(string email, string catch_all = "0")
        {
            return RequestHelper.Info(ApiKey, email, catch_all);
        }
    }
}

