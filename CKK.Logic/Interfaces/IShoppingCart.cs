using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Interfaces
{
    public interface IShoppingCart
    {
        public int GetCustomerId(int id);
        public decimal GetTotal();
        public ShoppingCartItem AddProduct(Product product, int quantity);
        public ShoppingCartItem RemoveProduct(int id, int quantity);
        public List<ShoppingCartItem> GetProducts();
        public ShoppingCartItem GetProductById(int id);

    }
}
