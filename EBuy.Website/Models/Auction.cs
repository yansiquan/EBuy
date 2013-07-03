using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EBuy.Website.Models
{
    public class Auction
    {
        public long Id { get; set; }

        [Required, StringLength(50, 
            ErrorMessage="Title cannot be longer than 50 characters")]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(1, 999999, 
            ErrorMessage="Auction starting price must be at least 1 and less than 1,000,000")]
        public decimal StartPrice { get; set; }

        public decimal CurrentPrice { get; set; }

        public DateTime StartTime { get; set; }

        [Range(typeof(DateTime), "1/1/2013", "12/31/9999")]
        public DateTime EndTime { get; set; }
    }
}