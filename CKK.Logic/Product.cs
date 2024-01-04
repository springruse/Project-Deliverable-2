using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic
{
    internal class Product
    {
        private int Id;
        private string Name;
        private decimal Price;

        public int GetId()
        {
            return Id;
        }

        public void SetId(int Id)
        {
            this.Id = Id;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public decimal GetPrice()
        {
            return Price;
        }

        public void SetPrice(int Price)
        {
            this.Price = Price;
        }
    }
}
