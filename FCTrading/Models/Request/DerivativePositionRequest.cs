﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSI.FCTrading.Client.Models.Request
{
    public class DerivativePositionRequest
    {
        public string account { get; set; }
        public bool querySummary { get; set; }
        
    }
}
