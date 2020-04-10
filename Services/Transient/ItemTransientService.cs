using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddServiceASP_core21.Models;
namespace AddServiceASP_core21.Services.Transient
{
    public class ItemTransientService : ITransient
    {
        Product product;
        int count=0;
        public ItemTransientService()
        {
            product = new Product
            {
                idProduct = 1,
                Title = "Test Transient:" + Guid.NewGuid(),
                UrlImage = "Transient.jpg",
                Price = 79000,
                Detail = "Transient"
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
