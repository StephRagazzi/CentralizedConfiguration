﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentralizedConfiguration.Models
{
    public class Site
    {
        public string Name { get; set; }
        public List<Config> Configs { get; set; }
    }
}