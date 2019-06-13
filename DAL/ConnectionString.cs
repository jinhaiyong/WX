using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Model;

namespace DAL
{
    public class ConnectionString : DbContext
    {
        public ConnectionString() : base("ConnectionString") { }

        public DbSet<sysUser> sysUsers { get; set; }
        public DbSet<sysRole> sysRoles { get; set; }
        public DbSet<sysUserRole> sysUserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
