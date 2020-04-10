using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AddServiceASP_core21.Models;
using AddServiceASP_core21.Services.Transient;
using AddServiceASP_core21.Services.Singleton;
using AddServiceASP_core21.Services.Scoped;
namespace AddServiceASP_core21.Controllers
{
    public class ProductController : Controller
    {
        /*Transient*/
        private readonly ITransient _transient1;
        private readonly ITransient _transient2;

        /*SingletoService*/
        private readonly ISingleton _singleton1;
        private readonly ISingleton _singleton2;

        /*ScopedService*/
        private readonly IScoped _scoped1;
        private readonly IScoped _scoped2;
        public ProductController(ITransient transient1, ITransient transient2,ISingleton singleton1, ISingleton singleton2, IScoped scoped1,IScoped scoped2)
        {
            _transient1 = transient1;
            _transient2 = transient2;

            _singleton1 = singleton1;
            _singleton2 = singleton2;

            _scoped1 = scoped1;
            _scoped2 = scoped2;

        }
         
        public IActionResult Index()
        {
            //Transient
            ViewBag.data01 = _transient1.getProduct();
            ViewBag.count01 = _transient1.countService();
            ViewBag.data02 = _transient2.getProduct();
            ViewBag.count02 = _transient2.countService();

            //Singleto
            ViewBag.data03 = _singleton1.getProduct();
            ViewBag.count03 = _singleton1.countService();
            ViewBag.data04 = _singleton2.getProduct();
            ViewBag.count04 = _singleton2.countService();


            //Scoped
            ViewBag.data05 = _scoped1.getProduct();
            ViewBag.count05 = _scoped1.countService();
            ViewBag.data06 = _scoped2.getProduct();
            ViewBag.count06 = _scoped2.countService();
          
            return View();
        }
    }
}