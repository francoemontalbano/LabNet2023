﻿using Ejercicio.EFU.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.EF.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext _northwindContext;


        public BaseLogic()
        {
            _northwindContext = new NorthwindContext();
        }
    }
}