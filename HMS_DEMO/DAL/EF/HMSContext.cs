using DAL.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    internal class HMSContext : DbContext
    {
        public DbSet<Agreement> Agreements { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Landlord> Landlords { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
