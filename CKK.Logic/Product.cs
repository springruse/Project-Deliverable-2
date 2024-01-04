using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic
{
    internal class Product
    {
        private int _id;
        private string _name;
        private decimal _price;

        public int GetId()
        {
            return _id;
        }

        public void SetId(int _id)
        {
            this.id = _id;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string _name)
        {
            this.name = _name;
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public void SetPrice(int _price)
        {
            this.price = _price;
        }
    }
}
