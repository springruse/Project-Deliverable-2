using System;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id;
        private string _name;
        private product _product1;
        private product _product2;
        private product _product3;

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

        public void AddStoreItem(product product)
        {

        }

        public void RemoveStoreItem(int ProductNum)
        {

        }

        public product GetStoreItem(int id)
        {
            
        }

        public product FindStoreItemByID(int id)
        {

        }
    }
}
