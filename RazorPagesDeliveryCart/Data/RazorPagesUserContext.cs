using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesDeliveryCart.Models;

    public class RazorPagesUserContext : DbContext
    {
        public RazorPagesUserContext (DbContextOptions<RazorPagesUserContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesDeliveryCart.Models.User> User { get; set; } = default!;

        public DbSet<RazorPagesDeliveryCart.Models.Employee>? Employee { get; set; }
    }
