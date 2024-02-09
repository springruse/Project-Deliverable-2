using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    internal class ShoppingCart
    {
        private string _customer;
        private Product _product1;
        private Product _product2;
        private Product _product3;

        public ShoppingCart(Customer customer)
        {
            _customer = customer;
        }

        public int GetCustomerId()
        {
            return 3;
        }

        public decimal GetDecimal()
        {
            return 0.0m;
        }

        public decimal GetTotal()
        {
            return 0.0m;
        }

        public int GetProduct(ShoppingCartItem prodNum)
        {
            return 3;
        }
        public int GetProductById(int id)
        {
            return 3;
        }

    }
}
