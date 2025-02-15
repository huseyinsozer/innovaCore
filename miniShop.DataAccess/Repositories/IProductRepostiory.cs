﻿using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniShop.DataAccess.Repositories
{
   public interface IProductRepostiory : IRepository<Product>
    {
        public IQueryable<Product> GetProductsByName(string name); 
    }
}
