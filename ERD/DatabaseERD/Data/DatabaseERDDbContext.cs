using Microsoft.EntityFrameworkCore;
using DatabaseERD.Models;
using Azure.Core;

namespace DatabaseERD.Data
{
    public class DatabaseERDDbContext : DbContext
    {
        public DatabaseERDDbContext(DbContextOptions<DatabaseERDDbContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<HealthCheck> HealthChecks { get; set; }
        public DbSet<SickLeave> SickLeaves { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Appeal> Appeals { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<AccessPermission> AccessPermissions { get; set; }
        public DbSet<ItemLoan> ItemLoans { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }


    }
}
