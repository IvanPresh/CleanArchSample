using BookShop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Infrastructure.Data
{
    public class MyBookShopContext : DbContext
    {

        public MyBookShopContext(DbContextOptions<MyBookShopContext> options) : base(options)
        {
        }
        public DbSet<Book> books { get; set; }
    }
}
