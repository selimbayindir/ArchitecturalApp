﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Company:BaseCommon,IEntity
    {
        public Company()
        {

        }
        public string Name { get; set; }

    }
}
