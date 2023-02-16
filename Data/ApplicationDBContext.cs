using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Baileys_Order_API.Models;

namespace Baileys_Order_API.Data
{
	public class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }
        //this is not being used at the moment but we might extend Identity user so this is what will do that.
        public DbSet<Order> Orders { get; set; } 
    }
}

