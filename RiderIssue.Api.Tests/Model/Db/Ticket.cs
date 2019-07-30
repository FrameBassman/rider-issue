using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RiderIssue.Api.Tests.Model.Db
{
    [Table("tickets")]
    public class Ticket
    {
        [Column("id")]
        public Int32 Id { get; set; }
        [Column("number")]
        public String Number { get; set; }
        [Column("roubles")]
        public Decimal Roubles { get; set; }
        [Column("expired")]
        public Boolean Expired { get; set; }
        [Column("event_name")]
        public String EventName { get; set; }
    }
}
