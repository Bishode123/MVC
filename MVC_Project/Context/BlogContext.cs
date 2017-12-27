using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC_Project.Models;

namespace MVC_Project.Context
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}