﻿using System.ComponentModel.DataAnnotations.Schema;

namespace api.DTOs.Stock
{
    public class CreateStockRequestDto
    {
        public string Symbol { get; set; } = string.Empty;

        public string CompanyName { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal LastDiv { get; set; }

        public string Indastry { get; set; } = string.Empty;

        public long MarketCap { get; set; }
    }
}