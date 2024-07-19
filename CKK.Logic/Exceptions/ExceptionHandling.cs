using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Exceptions
{
    public class InvalidIdException : Exception
    {
        public InvalidIdException()
            : base("An ID number was invalid.")
        {

        }

        public InvalidIdException(string message, Exception innerException)
            : base(message, innerException)
        {

        }

    }
    public class InventoryItemStockTooLowException : Exception
    {
        public InventoryItemStockTooLowException()
            : base("The selected item's stock is too low.")
        {

        }

        public InventoryItemStockTooLowException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
    public class ProductDoesNotExistException : Exception
    {
        public ProductDoesNotExistException()
            : base("The Product you are looking for doesn't exist.")
        {

        }

        public ProductDoesNotExistException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
