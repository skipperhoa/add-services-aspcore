using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddServiceASP_core21.Models;
namespace AddServiceASP_core21.Services.Singleton
{
    public interface ISingleton
    {
        Product getProduct();
        int countService();
    }
}
