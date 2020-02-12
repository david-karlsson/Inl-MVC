using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Inlämnings_MVC.Models;

namespace Inlämnings_MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Inlämnings_MVC.Models.Customer> Customer { get; set; }
        public DbSet<Inlämnings_MVC.Models.Issue> Issue { get; set; }
        public DbSet<Inlämnings_MVC.Models.IssueStatus> IssueStatus { get; set; }
    }
}
