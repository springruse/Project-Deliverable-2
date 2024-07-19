using CKK.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCartItem : InventoryItem
    {


        public ShoppingCartItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public int GetQuantity()
        {
            return Quantity;
        }

        public void SetQuantity(int quantity)
        {
            this.Quantity = quantity;
        }

        public Product GetProduct()
        {
            return Product;
        }

        public void SetProduct(Product product)
        {
            this.Product = product;
        }

        public decimal GetTotal()
        {
            decimal total = Quantity * Product.GetPrice();
            return total;
        }

    }

}
