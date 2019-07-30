using System;
using Microsoft.Extensions.Configuration;

namespace RiderIssue.Api.Environment
{
    public class AppSettings
    {
        private readonly IConfiguration _configuration;
        private readonly AppHost _host;
        
        public AppSettings(IConfiguration configuration)
        {
            _configuration = configuration;
            _host = new AppHost();
        }

        public String ConnectionString()
        {
            return _configuration
                .GetConnectionString("DefaultConnection")
                .Replace("$DOCKER_HOST", _host.Value());
        }
    }
}