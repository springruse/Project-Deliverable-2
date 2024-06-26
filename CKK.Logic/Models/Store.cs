﻿using System;
using System.Dynamic;
using System.Linq;
using System.Collections.Generic;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class Store : Entity
    {

        /*
        private Product _product1;
        private Product _product2;
        private Product _product3;
        */

        List<StoreItem> products = new List<StoreItem>();

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
            if (quantity < 0)
            {
                return null;
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

       

            
            /*if (_product1 == null)
            {
                _product1 = product;
            }
            else if (_product2 == null)
            {
                _product2 = product;
            }
            else if (_product3 == null)
            {
                _product3 = product;
             }*/
        }

        public StoreItem RemoveStoreItem(int id, int quantity)
        {

            if (quantity < 0)
            {
                return null;
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
            return null;

            /*if (ProductNum == 1 && _product1 != null)
            {
                _product1 = null;
            }
            else if (ProductNum == 2 && _product2 != null)
            {
                _product2 = null;
            }
            else if (ProductNum == 3 && _product3 != null)
            {
                _product3 = null;
            }*/
        }

        public List<StoreItem> GetStoreItems()
        {
            return products;

            
            /*if (ProductNum == 1 && _product1 != null)
            {
                return _product1;
            }
            else if (ProductNum == 2 && _product2 != null)
            {
                return _product2;
            }
            else if (ProductNum == 3 && _product3 != null)
            {
                return _product3;
            }
            else 
            { 
                return null; 
            }*/
        }

        public StoreItem FindStoreItemById(int id)
        {
            return products.Find(x => x.GetProduct().GetId() == id);
        }
            /*
            if (_product1 != null && _product1.GetId() == id) 
            {
                return _product1;
            }
            else if (_product2 != null && _product2.GetId() == id)
            {
                return _product2;
            }
            else if (_product3 != null && _product3.GetId() == id)
            {
                return _product3;
            }
            else
            {
                return null;
            }
            */
        
    }
}
