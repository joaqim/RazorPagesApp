using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;

namespace RazorPagesApp.Data
{
    public class RazorPagesPostContext : DbContext
    {
        public RazorPagesPostContext (DbContextOptions<RazorPagesPostContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesApp.Models.Post>? Post { get; set; }
    }
}