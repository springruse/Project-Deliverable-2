namespace CKK.Logic
{
    public class Customer
    {
        private int Id;
        private string Name;
        private string Address;

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