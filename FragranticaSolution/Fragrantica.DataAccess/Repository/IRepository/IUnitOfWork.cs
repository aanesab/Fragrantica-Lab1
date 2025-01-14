using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fragrantica.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        //IShoppingCartRepository ShoppingCart { get; }
        ICategoryRepository Category { get; }
        //IProductRepository Product { get; }
        //ICompanyRepository Company { get; }
        //IApplicationUserRepository ApplicationUser { get; }
        //IOrderHeaderRepository OrderHeader { get; }
        //IOrderDetailRepository OrderDetail { get; }



        void Save();
    }
}
