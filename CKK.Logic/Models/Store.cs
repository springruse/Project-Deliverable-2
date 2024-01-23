using System;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id;
        private string _name;
        private Product _product1;
        private Product _product2;
        private Product _product3;

        public int GetId()
        {
            return _id;
        }

        public void SetID(int id)
        {
            this._id = id;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            this._name = name;
        }

        public void AddStoreItem(Product product)
        {
            if (_product1 == null)
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
            }
        }

        public void RemoveStoreItem(int ProductNum)
        {
            if (ProductNum == 1 && _product1 != null)
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
            }
        }

        public Product GetStoreItem(int productNum)
        {
            if (ProductNum == 1 && _product1 != null)
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
            }
        }

        public Product FindStoreItemByID(int id)
        {
            if (_product1 != null && _product1.GetId() == id) 
            {
                return _product1;
            }
            else if (_product2 != null && _product1.GetId() == id)
            {
                return _product2;
            }
            else if (_product3 != null && _product1.GetId() == id)
            {
                return _product3;
            }
            else
            {
                return null;
            }
        }
    }
}
