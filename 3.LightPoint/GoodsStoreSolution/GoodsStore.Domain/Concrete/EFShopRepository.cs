using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodsStore.Domain.Abstract;

namespace GoodsStore.Domain.Concrete
{
    public class EFShopRepository: IShopRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Shop> Shops //Realization IShopRepository
        {
            get { return context.Shops.ToList(); }
        }
    }
}
