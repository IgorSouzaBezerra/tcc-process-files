﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessFile.API.Domain.Entities
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }
    }
}
