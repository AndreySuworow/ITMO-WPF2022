using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Final.Models
{
    public class UsersContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<AcademicPlan> AcademicPlans { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<User> Users { get; set; }
    }
}