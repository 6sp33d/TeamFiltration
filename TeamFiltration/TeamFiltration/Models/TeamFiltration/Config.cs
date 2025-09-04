﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TeamFiltration.Models.TeamFiltration
{
    public class Config { 
    
        public string PushoverAppKey { get; set; }
        public string PushoverUserKey { get; set; }

        public string DehashedApiKey { get; set; }
        public string DehashedEmail { get; set; }

        public string SacrificialO365Username { get; set; }
        public string SacrificialO365Passwords { get; set; }

        public string proxyEndpoint { get; set; }


        public string UserAgent { get; set; } 

    }
}
