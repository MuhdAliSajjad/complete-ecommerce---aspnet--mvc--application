﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Actor_Movies
    {

        public int MovieId { get; set; }
        public MoviesModel Movie { get; set; }
        public int ActorId { get; set; }
        public ActorModel Actor { get; set; }
    }
}
