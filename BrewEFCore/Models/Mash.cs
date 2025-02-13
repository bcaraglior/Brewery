﻿using System;
using System.Collections.Generic;

namespace BrewEFCore.Models
{
    public partial class Mash
    {
        public Mash()
        {
            MashStep = new HashSet<MashStep>();
            Recipe = new HashSet<Recipe>();
        }

        public int MashId { get; set; }
        public string Name { get; set; }
        public int? Version { get; set; }
        public double? GrainTemp { get; set; }
        public double? TunTemp { get; set; }
        public double? SpargeTemp { get; set; }
        public double? Ph { get; set; }
        public double? TunWeight { get; set; }
        public double? TunSpecificHeat { get; set; }
        public byte? EquipmentAdjust { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<MashStep> MashStep { get; set; }
        public virtual ICollection<Recipe> Recipe { get; set; }
    }
}
