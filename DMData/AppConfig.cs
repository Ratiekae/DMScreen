﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DMData.AppConfig
{
    class AppConfig
    {
        public static string DynamicsConnectionString
        {
            get { return ConfigurationSettings.AppSettings["DynamicsConnectionString"].ToString(); }
        }
    }
}
