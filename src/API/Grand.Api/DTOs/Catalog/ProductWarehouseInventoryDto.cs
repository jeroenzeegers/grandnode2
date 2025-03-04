﻿using Grand.Api.Models;

namespace Grand.Api.DTOs.Catalog
{
    public class ProductWarehouseInventoryDto : BaseApiEntityModel
    {
        public string WarehouseId { get; set; }
        public int StockQuantity { get; set; }
        public int ReservedQuantity { get; set; }
    }
}
