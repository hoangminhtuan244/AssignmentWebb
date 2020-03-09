using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AssignmentWeb.Models
{
    public class MyDatabaseContext : DbContext

    {
        public MyDatabaseContext() : base("Myconection") { }
        public DbSet<Student> Students { get; set; }
    }
}