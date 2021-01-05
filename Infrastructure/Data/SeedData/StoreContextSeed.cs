﻿using Core.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Infrastructure.Data.SeedData
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext contex, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!contex.ProductBrands.Any())
                {
                    var brandData =
                        File.ReadAllText("../Infrastructure/Data/SeedData/Brands.json");
                    var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandData);

                    foreach (var item in brands)
                    {
                        contex.ProductBrands.Add(item);
                    }
                    await contex.SaveChangesAsync();
                }

                if (!contex.ProductTypes.Any())
                {
                    var typesData =
                        File.ReadAllText("../Infrastructure/Data/SeedData/types.json");
                    var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);

                    foreach (var item in types)
                    {
                        contex.ProductTypes.Add(item);
                    }
                    await contex.SaveChangesAsync();
                }

                if (!contex.Products.Any())
                {
                    var productsData =
                        File.ReadAllText("../Infrastructure/Data/SeedData/products.json");
                    var products = JsonSerializer.Deserialize<List<Product>>(productsData);

                    foreach (var item in products)
                    {
                        contex.Products.Add(item);
                    }
                    await contex.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}
