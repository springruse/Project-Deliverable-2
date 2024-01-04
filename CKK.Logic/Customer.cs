namespace CKK.Logic
{
    public class Customer
    {
        private int _id;
        private string _name;
        private string _address;

        public int getId()
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

        public string GetAddress()
        {
            return _address;
        }

        public void SetAddress(string _address)
        {
            this.address = _address;
        }
    }

}