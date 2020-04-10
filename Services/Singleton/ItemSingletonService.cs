using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddServiceASP_core21.Models;
namespace AddServiceASP_core21.Services.Singleton
{
    public class ItemSingletonService : ISingleton
    {
        Product product;
        int count = 0;
       
        public ItemSingletonService()
        {
            product = new Product
            {
                idProduct = 1,
                Title = "Test Singleto:" + Guid.NewGuid(),
                UrlImage = "Singleto.jpg",
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
