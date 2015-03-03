using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentralizedConfiguration.Models
{
    public class Products
    {
        public string Name { get; set; }
        public Config Config { get; set; }
    }
}