using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> Customers = new List<Customer>
        {
            new Customer {Id = 1, Name = "Patrick Suazey"},
            new Customer {Id = 2, Name = "Gal Gadot"}
        };
        // GET: Customers
        public ActionResult Index()
        {
            //var  customer = new Customer { Id = 1, Name = "Patrick Suazey" };
            //var  customer2 = new Customer { Id = 2, Name = "Gal Gadot" };

            List<Customer> customers = Customers;
            //var ListCustomers = new CustomerViewModel {CustomersList = customers};
            return View(customers);
        }

        public ActionResult Details(int id)
        {

            Customer custic = new Customer();

            foreach(var item in Customers)
            {
                if(item.Id == id)
                {
                    custic = item;
                    return View(custic);
                }
     
            }

                return HttpNotFound();
        }
    }
}