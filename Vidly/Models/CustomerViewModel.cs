using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class CustomerViewModel
    {
       public IEnumerable<CustomerViewModel> CustomersList { get; set; }
        
    }
}