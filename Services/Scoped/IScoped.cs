using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddServiceASP_core21.Models;
namespace AddServiceASP_core21.Services.Scoped
{
    public interface IScoped
    {
        Product getProduct();
        int countService();
    }

}
