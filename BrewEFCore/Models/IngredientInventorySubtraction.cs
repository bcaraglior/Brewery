﻿using System;
using System.Collections.Generic;

namespace BrewEFCore.Models
{
    public partial class IngredientInventorySubtraction
    {
        public int IngredientInventorySubtractionId { get; set; }
        public int IngredientId { get; set; }
        public string Reason { get; set; }
        public int? BatchId { get; set; }
        public double Quantity { get; set; }

        public virtual Batch Batch { get; set; }
        public virtual Ingredient Ingredient { get; set; }
    }
}
