using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace CentralizedConfiguration.Models
{
    public class Config
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public XmlDocument Config { get; set; }
    }
}