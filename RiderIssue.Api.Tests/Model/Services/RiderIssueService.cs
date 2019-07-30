using System;
using RestSharp;
using RiderIssue.Api.Tests.Environment;

namespace RiderIssue.Api.Tests.Model.Services
{
    public abstract class RiderIssueService
    {
        protected RestClient Client;
        protected abstract int Port();

        public RiderIssueService()
        {
            Client = new RestClient(
                new UriBuilder(
                    "http",
                    new AppHost().Value(),
                    this.Port()
                ).Uri
            );
            Client.RemoteCertificateValidationCallback = 
                (sender, certificate, chain, sslPolicyErrors) => true;
        }
    }
}
