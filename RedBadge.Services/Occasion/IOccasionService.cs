﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadge.Services.Occasion
{
    internal class IOccasionService
    {
        Task<bool> CreateOccasionAsync(OccasionCreate occasionToCreate);
    }
}
