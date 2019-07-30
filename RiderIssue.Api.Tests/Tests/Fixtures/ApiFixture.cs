using System;
using System.Collections.Generic;
using System.Linq;
using RiderIssue.Api.Tests.Data;
using RiderIssue.Api.Tests.Model.Db;
using RiderIssue.Api.Tests.Model.Services;

namespace RiderIssue.Api.Tests.Tests.Fixtures
{
    public class ApiFixture : IDisposable
    {
        private readonly Generator _generator;
        public readonly ApiService Api;
        public readonly ApplicationContext Db;

        public ApiFixture()
        {
            _generator = new Generator();
            Api = new ApiService();
            Db = new ApplicationContext();
            CleanUpDatabase();
            SeedTestData();
            Db.SaveChanges();
        }
        
        public void Dispose()
        {
            Db.Dispose();
        }
        
        public void CleanUpDatabase()
        {
            if (Db.Tickets.Count() != 0)
            {
                Db.Tickets.RemoveRange(Db.Tickets);
            }
        }

        public void SeedTestData()
        {
            var max = 10;
            var result = new List<Ticket>();
            for (int i = 0; i < max; i++)
            {
                result.Add(
                    new Ticket
                        {
                            EventName = _generator.RandomEventName(),
                            Expired = _generator.RandomBoolean(),
                            Number = _generator.RandomNumber(),
                            Roubles = _generator.RandomPrice()
                        }
                    );
            }
            Db.Tickets.AddRange(result);
        }
    }
}
