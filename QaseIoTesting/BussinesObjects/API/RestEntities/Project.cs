﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesObjects.API.RestEntities
{
    public class Project
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public Counts Counts { get; set; }
    }
}
