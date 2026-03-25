using NUnit.Framework;
using Project.Advanced;
using Project.Model;

namespace UnitTest_nunit.Advanced
{
    [TestFixture]
    public class ProductTest
    {

        Product product;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            // This method will be called once before any of the test methods are executed
            // You can use it to set up shared resources, initialize database connections, etc.
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            // This method will be called once after all the test methods have been executed
            // You can use it to clean up shared resources, close database connections, etc.
        }

        // This method will be called before each test method is executed
        [SetUp]
        public void Setup()
        {
            product = new Product();
        }

        // This method will be called after each test method is executed
        [TearDown]
        public void TearDown()
        {
            // Clean up resources if needed
            // disconnect from database, release file handles, etc.
        }


        [Test]
        [Ignore("For Develpoment Purpose", Until = "2026-3-25 5:31AM")]
        [Category("FirstClass")]
        public void checkProductFirstClass()
        {

            var result = product.ReturnProductClassBasedOnPrice(1050);

            Assert.That(result, Is.EqualTo(ProductClassEnum.FirstClass.ToString()));
        }

        [Test]
        [Category("SecondClass")]
        public void checkProductSecondClass()
        {

            var result = product.ReturnProductClassBasedOnPrice(800);

            Assert.That(result, Is.EqualTo(ProductClassEnum.SecondClass.ToString()));
        }

    }
}
