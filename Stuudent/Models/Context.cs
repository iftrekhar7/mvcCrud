using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Stuudent.Models
{
    public class Context : DbContext
    {
        public Context()
            : base("DefaultConnection")
        { }
        public DbSet<Student> Students { get; set; }
    }
    
}