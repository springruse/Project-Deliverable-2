using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer _customer;
        private ShoppingCartItem _product1;
        private ShoppingCartItem _product2;
        private ShoppingCartItem _product3;

        public ShoppingCart(Customer customer)
        {
            _customer = customer;   
        }

        public int GetCustomerId(int id)
        {
            return _customer.GetId();
        }

        public decimal GetTotal()
        {
            var grandTotal = 0m;

            if (product1 != null)
            {
                grandTotal += product1.GetTotal();
            }
            else if (product2 != null)
            {
                grandTotal += product2.GetTotal();
            }
            else if (product3 != null)
            {
                grandTotal += product3.GetTotal();
            }
            return grandTotal;
        }

        public ShoppingCartItem AddProduct(Product product, int quantity)
        {
            if (quantity < 1)
            {
                return null;
            }
            else if (product1 != null && product1.GetProduct().GetId() == product.GetId())
            {
                product1.SetQuantity(product1.GetQuantity() + quantity);
                return product1;
            }
            else if (product1 != null && product2.GetProduct().GetId() == product.GetId())
            {
                product1.SetQuantity(product1.GetQuantity() + quantity);
                return product2;
            }
            else if (product3 != null && product3.GetProduct().GetId() == product.GetId())
            {
                product1.SetQuantity(product1.GetQuantity() + quantity);
                return _product3;
            }
            return null;
        }
        public ShoppingCartItem AddProduct(Product product)
        {
            return AddProduct(product, 1);
        }

        public ShoppingCartItem GetProductById(int id)
        {
            if (product1.GetProduct().GetId() == id)
            {
                return product1;
            }
            else if (product2.GetProduct().GetId() == id)
            {
                return product2;
            }
            else if (product3.GetProduct().GetId() == id)
            {
                return product3;
            }
            return null;
        }

        public ShoppingCartItem RemoveProduct(Product product, int quantity)
        {
            if (quantity < 1)
            {
                return null;
            }

            else if (product1 != null && product1.GetProduct().GetId() == product.GetId() )
            {
                product1.SetQuantity(product1.GetQuantity() - quantity);
                if (product1.GetQuantity() < 1)
                {
                    return null;
                }
                return product1;
            }

            else if (product2 != null && product2.GetProduct().GetId() == product.GetId())
            {
                product2.SetQuantity(product2.GetQuantity() - quantity);
                if (product2.GetQuantity() < 2)
                {
                    return null;
                }
                return product2;
            }

            else if (product3 != null && product3.GetProduct().GetId() == product.GetId())
            {
                product3.SetQuantity(product3.GetQuantity() - quantity);
                if (product3.GetQuantity() < 1)
                {
                    return null;
                }
                return product3;
            }
            return null;
        }
        public ShoppingCartItem GetProduct(int productNumber)
        {
            if (productNumber == 1)
            {
                return _product1;
            }
            else if (productNumber == 2)
            {
                return _product2;
            }
            else if (productNumber == 3)
            {
                return _product3;
            }
            return  null;
        }


    }
}
