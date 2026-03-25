using NUnit.Framework;
using Project.Model;

namespace UnitTest_nunit
{
    [TestFixture]
    public class Product_Test
    {
        [Test]
        public void Test_Has_Name_Property()
        {
            // Arrange
            var product = new Product { Id = 1, Name = "Test Product" };
            // Act & Assert
            Assert.That(product, Has.Property("Name"));
        }
    }
}
