﻿using DataLayer.Entities;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Orcus.Abstraction
{
    public interface IProductService
    {
        public IEnumerable<ProductUnitTypeModel> GetProductUnitTypes();
        public bool AddProductUnitTypes(ProductUnitTypeModel productUnitType);
        public bool PurchaseProduct(ProductModel product, out int productId);
        public bool? SellProduct(ProductModel product);
        public IEnumerable<ProductModel> GetInventory(string userId, int? outletId);
        public bool? ArchiveProduct(string userId, int productId);
    }
}
