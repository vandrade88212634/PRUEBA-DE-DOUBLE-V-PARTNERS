using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TICKETS.Entities;

namespace TICKETS.Context
{
    public class TicketDbContext : DbContext
    {
        public TicketDbContext(DbContextOptions<TicketDbContext> options)
            :base(options)
        {


        }
        public DbSet<Ticket> ticket { get; set; }
    }
}
