﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product  = new Product(productId); //Arrange 
            
            if(productId == 2)
            {
                product.ProductName = "Sunflower";
                product.ProductDescreption = "Bright yellow ";
                product.CurrentPrice = 15.99M;

            }
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"product: {myObject.ToString()}");
            return product;

        }
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanged)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
