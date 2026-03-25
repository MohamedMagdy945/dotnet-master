using NUnit.Framework;
using Project;

namespace UnitTest_nunit
{
    [TestFixture]
    public class Calculator_Test
    {
        [Test]
        public void Add_int_Test_Positive_Numbers()
        {
            // AAA

            // Arrange
            Calculator calculator = new Calculator();


            // Act
            int result = calculator.Add_int(5, 10);

            // Assert
            Assert.AreEqual(15, result);

            //Assert.That(result, Is.EqualTo(15));
        }

        [Test]
        public void Div_Double_Test()
        {
            Calculator calculator = new Calculator();

            var result = calculator.Divide_int(1, 3);

            Assert.That(result, Is.EqualTo(.333).Within(.004));
        }
        [Test]
        public void Div_Double_Test_Divide_By_Zero()
        {
            Calculator calculator = new Calculator();
            //Assert.Throws<DivideByZeroException>(() => calculator.Divide_int(1, 0));
            Assert.That(() => calculator.Divide_int(1, 0), Throws.TypeOf<DivideByZeroException>());
        }
    }
}