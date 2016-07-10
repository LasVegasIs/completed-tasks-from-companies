using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoodsStore.WebUI.DBContext1;
using System.Data.Entity;

namespace GoodsStore.WebUI.DBContext1
{
    public class DbTaskContext : DbContext
    {
        public DbTaskContext() //паблик конструктор    
            : base("dbTaskConnection")
        {
        }
        public DbSet<Blog> Blogs { get; set; }//свойство содержащее объект таблицы Blog
        public DbSet<Post> Posts { get; set; }//свойство содержащее объект таблицы Post
    }
}