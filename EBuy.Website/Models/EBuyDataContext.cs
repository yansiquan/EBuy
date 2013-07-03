using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EBuy.Website.Models
{
    public class EBuyDataContext : DbContext
    {
        public DbSet<Auction> Auctions { get; set; }
    }
}