using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.Services
{
    public class ProductsService : IProductsService
    {
        private readonly ProductsDbContext _context;

        public ProductsService(ProductsDbContext context)
        {
            _context = context;
        }
        public bool Add(Products entity)
        {
            _context.Products.Add(entity);
            return true;
        }

        public bool Delete(Products entity)
        {
            throw new NotImplementedException();
        }

        public List<Products> List()
        {
            return _context.Products.ToList();
        }

        public bool Update(Products entity)
        {
            throw new NotImplementedException();
        }
    }
}
