﻿using ReDoMusic.Domain.Common;
using ReDoMusic.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ReDoMusic.Domain.Entities
{
    public class Instrument : EntityBase<Guid>
    {
        public string Name { get; set; }
        public Brand Brand { get; set; }
        public string Model  { get; set; }
        public string Color { get; set; }
        public DateTime? ProductionYear { get; set; }
        public decimal Price { get; set;}

    }
}
