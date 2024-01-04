namespace CKK.Logic.Models
{
    public class Customer
    {
        private int Id;
        private string Name;
        private string Address;

        public string Name
        {
            get { return Name;}
            set { 
                if (value == Name)
            }
        }

        public string Address
        {
            get { return Address;}
            set { 
                if (value == Address)
            }
        }

        public int Id
        {
            get { return Id;}
            set { 
                if (value == Id)
            }
        }

        public int getId()
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

        public string GetAddress()
        {
            return Address;
        }

        public void SetAddress(string Address)
        {
            this.Address = Address;
        }
    }

}