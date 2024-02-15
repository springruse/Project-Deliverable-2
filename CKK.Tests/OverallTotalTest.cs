using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;
using CKK.Logic.Models;

namespace CKK.tests
{
    public class OverallTotalTest
    {
        [Fact]
        public void CheckToSeeIfTotalIsAccurate()
        {
            try
            {
                Customer customer1 = new Customer();

                Product product1 = new Product();
                product1.SetId(1);
                product1.SetName("Bowling Ball");
                product1.SetPrice(40.0m);

                Product product2 = new Product();
                product2.SetId(2);
                product2.SetName("Kid Bike");
                product2.SetPrice(20.0m);

                ShoppingCart cart1 = new ShoppingCart(customer1);

                cart1.AddProduct(product1, 1);
                cart1.AddProduct(product2, 2);
               
                decimal expected = 80.0m;
                decimal actual = cart1.GetTotal();
                Assert.Equal(expected, actual);
            }
            catch
            {
                throw new XunitException("The total does not add up correctly together.");
            }
        }
    }
}
