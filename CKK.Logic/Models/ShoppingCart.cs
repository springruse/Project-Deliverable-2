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
        public Customer Customer { get; set; }
        public Product Products { get; set; }

        /*
        private ShoppingCartItem _product1;
        private ShoppingCartItem _product2;
        private ShoppingCartItem _product3;
        */

        List<ShoppingCartItem> items = new List<ShoppingCartItem>();

        public ShoppingCart(Customer customer)
        {
            Customer = customer;   
        }

        public int GetCustomerId(int id)
        {
            return Customer.GetId();
        }

        public decimal GetTotal()
        {

            var grandTotal = 0m;

            foreach (ShoppingCartItem product in items)
            {
                grandTotal += product.GetTotal();
            }

            return grandTotal;

        }

        public ShoppingCartItem AddProduct(Product product, int quantity)
        {
            if (quantity < 0)
            {
                return null;
            }

            var additem = GetProductById(product.GetId());

            if (additem != null)
            {
                additem.SetQuantity(additem.GetQuantity() + quantity);
                return additem;
            }

            ShoppingCartItem itemAdd = new ShoppingCartItem(product, quantity);
            items.Add(itemAdd);
            return itemAdd;

        }
        
       
        public ShoppingCartItem AddProduct(Product product)
        {
            return AddProduct(product, 1);
        }

        public ShoppingCartItem GetProductById(int id)
        {
            return items.Find(x => x.GetProduct().GetId() == id);
          
        }

        public ShoppingCartItem RemoveProduct(int id, int quantity)
        {
            if (quantity < 0)
            {
                return null;
            }

            var additem = GetProductById(id);

            if (additem != null)
            {
                if (additem.GetQuantity() - quantity <= 0)
                {
                    additem.SetQuantity(0);
                    items.Remove(additem);
                    return additem;
                }

                additem.SetQuantity(additem.GetQuantity() - quantity);
                return additem;
            }
            return null;


        }

        public List<ShoppingCartItem> GetProducts()
        {
            return items;
        }
    }
}
