using Fragrantica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Fragrantica.DataAccess.Repository.IRepository
    {
        public interface IProductRepository : IRepository<Product>
        {
            void Update(Product obj);
           

        }
    }
