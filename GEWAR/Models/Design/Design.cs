﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEWAR.Models
{
    internal class Design
    {
       
            public int DesignID { get; set; }
            public int RequestID { get; set; }
            public int DesignerID { get; set; }
            public string DesignURL { get; set; }
            public bool AI_Generated { get; set; }
            public string SelectedStyle { get; set; }
            public DateTime CreationDate { get; set; }
        }
    }
