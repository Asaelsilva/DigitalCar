﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllConfiguracao
{
    public class Configuracao
    {
        public string StrConfiguracao { get; set; }

        public Configuracao()
        {
           StrConfiguracao = ConfigurationManager.ConnectionStrings["DigitalCar"].ConnectionString;
        }

        
    }
}
