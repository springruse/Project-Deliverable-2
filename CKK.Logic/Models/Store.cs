using System;
using System.Dynamic;
using System.Linq;
using System.Collections.Generic;
using CKK.Logic.Interfaces;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Models
{
    public class Store : Entity , IStore
    {

        public List<StoreItem> products = new List<StoreItem>();

        public int GetId()
        {
            return Id;
        }

        public void SetId(int id)
        {
            this.Id = id;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }

        public StoreItem AddStoreItem(Product product, int quantity)
        {
            if (quantity <= 0)
            {
                throw new InventoryItemStockTooLowException();
            }

            var additem = FindStoreItemById(product.GetId());

            if (additem != null)
            {
                additem.SetQuantity(additem.GetQuantity() + quantity);
                return additem;
            }

            StoreItem itemAdd = new StoreItem(product, quantity);
            products.Add(itemAdd);
            return itemAdd;

        }

        public StoreItem RemoveStoreItem(int id, int quantity)
        {

            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            var additem = FindStoreItemById(id);

            if (additem != null)
            {
                if (additem.GetQuantity() - quantity > 0)
                {
                    additem.SetQuantity(additem.GetQuantity() - quantity);
                    return additem;
                }

                additem.SetQuantity(0);
                return additem;
            }
            throw new ProductDoesNotExistException();
        }

        public List<StoreItem> GetStoreItems()
        {
            return products;
        }

        public StoreItem FindStoreItemById(int id)
        {
            if (id < 0)
            {
                throw new InvalidIdException();
            }
            return products.Find(x => x.GetProduct().GetId() == id);
        }
        
    }
}
