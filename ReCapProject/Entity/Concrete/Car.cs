﻿using System;
namespace Entities.Concrete
{
    public class Car
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
// Id, BrandId, ColorId, ModelYear, DailyPrice, Description