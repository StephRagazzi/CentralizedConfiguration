using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentralizedConfiguration.Models
{
    public class Sites
    {
        public string Name { get; set; }
        public List<Products> Products { get; set; }
    }
}