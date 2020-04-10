using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddServiceASP_core21.Models;
namespace AddServiceASP_core21.Services.Scoped
{
    public class ItemScopedService : IScoped
    {
        Product product;
        int count = 0;
        public ItemScopedService()
        {
            product = new Product
            {
                idProduct = 1,
                Title = "Test Scoped:" + Guid.NewGuid(),
                UrlImage = "Scoped.jpg",
                Price = 79000,
                Detail = "Singleto"
            };
        }
        public Product getProduct()
        {
            count++;
            return product;

        }
      
        public int countService()
        {
            return count;
        }
    }
}
