﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Data.Base
{
    public interface IEntityBase 
    {
        int Id { get; set; }
 
    }
}
