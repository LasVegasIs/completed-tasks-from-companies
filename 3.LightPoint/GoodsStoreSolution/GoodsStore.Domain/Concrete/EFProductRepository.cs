using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodsStore.Domain.Abstract;
using System.Data.SqlClient;
using System.Data.Entity.Core.Objects;

namespace GoodsStore.Domain.Concrete
{
    public class EFProductRepository: IProductRepository
    {
        private EFDbContext context = new EFDbContext();
        
        public IQueryable<Product> Products//Realization IProductRepository
        {
            get { return context.Products; }
        }

        public IEnumerable<Product> GetProductsByShop(int shopId)
        {
            string strQuery = "select p.* from Shops s, Products p, Shop_Products sp " +
                                            "where s.ShopID = sp.ShopID AND " +
                                            "p.ProductID = sp.ProductID AND " +
                                            "s.ShopID = @param1";
            SqlParameter param = new SqlParameter("param1", shopId);
            return context.Products.SqlQuery(strQuery, param).ToList();
        }

        
    }
}
