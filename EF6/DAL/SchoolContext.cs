using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using EF6.Models;

namespace EF6.DAL {
    public class SchoolContext : DbContext {

        public SchoolContext() : base("SchoolContext") {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            //避免table變成複數
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}