using CKK.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Models
{
    public class ShoppingCart : IShoppingCart
    {
        public Customer Customer { get; set; }
        public Product Products { get; set; }
      
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
            if (quantity <= 0)
            {
                throw new InventoryItemStockTooLowException();
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
            if (id < 0)
            {
                throw new InvalidIdException();
            }

            return items.Find(x => x.GetProduct().GetId() == id);

        }

        public ShoppingCartItem RemoveProduct(int id, int quantity)
        {
            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException();
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
            throw new ProductDoesNotExistException();
        }

        public List<ShoppingCartItem> GetProducts()
        {

            return items;

        }
    }
}
