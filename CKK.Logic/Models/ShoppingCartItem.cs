﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCartItem
    {
        private Product _product;
        private int _quantity;

        public ShoppingCartItem(Product product, int quantity)
        {
            _product = product;
            _quantity = quantity;
        }

        public int GetQuantity(int quantity)
        {
            return _quantity;
        }

        public void SetQuantity(int quantity)
        {
            this._quantity = quantity;
        }

        public Product GetProduct(Product product)
        {
            return _product;
        }

        public void SetProduct(Product product)
        {
            this._product = product;
        }

    }

     

    
}
