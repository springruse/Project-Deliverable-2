using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;
using CKK.Logic.Models;

namespace CKK.tests
{
    public class AddingProductTest
    {
        [Fact]
        public void CheckToSeeIfProductWasAdded()
        {
            try
            {
                Customer customer1 = new Customer();

                Product product1 = new Product();
                product1.SetId(1);
                product1.SetName("Bowling Ball");
                product1.SetPrice(40.00m);

                Product product2 = new Product();
                product2.SetId(2);
                product2.SetName("Kid Bike");
                product2.SetPrice(20.00m);


                ShoppingCart Cart1 = new ShoppingCart(customer1);

                Cart1.AddProduct(product1, 1);

                Assert.NotNull(Cart1.GetProduct(1));
                
            }
            catch
            {
                throw new XunitException("A product was not correctly added.");
            }
        }
    }
}
