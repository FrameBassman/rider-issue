using System;

namespace RiderIssue.Api.Environment
{
    public class AppHost
    {
        public String Value()
        {
            var variable = System.Environment.GetEnvironmentVariable("DOCKER_HOST");
            if (String.IsNullOrEmpty(variable))
            {
                return "localhost";
            }
            else
            {
                return new UriBuilder(variable).Host;
            }
        }
    }
}