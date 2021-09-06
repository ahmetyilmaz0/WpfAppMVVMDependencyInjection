using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class ProductsDbContext:DbContext
    {
        static ProductsDbContext()
        {
            
        }
        #region Contructor
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        #endregion

        #region Public properties
        public virtual DbSet<Products> Products { get; set; }
        #endregion

        #region Override method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Products>().HasData(Products);
            //base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
