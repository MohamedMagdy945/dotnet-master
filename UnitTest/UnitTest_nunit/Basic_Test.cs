using NUnit.Framework;
using Project;

namespace UnitTest_nunit
{
    [TestFixture]
    public class Basic_Test
    {
        [Test]
        public void Test_References()
        {
            Calculator calculator1 = new Calculator();
            Calculator calculator2 = calculator1;
            Calculator calculator3 = new Calculator();

            //Assert.That(calculator1, Is.SameAs(calculator1));
            //Assert.That(calculator1, Is.Not.SameAs(calculator2));
            Assert.That(calculator1, Is.SameAs(calculator3), "References are not the same");
        }
        [Test]
        public void Test_collection_Number_Of_Items()
        {
            var names = new List<string> { "Ahmed", "Sara", "Hany", "Fatma", "Mariam", "Ahmed" };

            //Assert.That(names, Has.Exactly(6).Items);
            //Assert.That(names, Is.Unique);
            //Assert.That(names, Is.Not.Empty);
            //Assert.That(names, Does.Contain("AHMED").IgnoreCase);
            //Assert.That(names, Has.Exactly(2).EqualTo("Ahmed").And.Exactly(1).EqualTo("Hany"));
            Assert.That(names, Has.Exactly(2).Matches<string>(n => n.Contains("Ahm")));
        }

        [Test]
        public void Test_String()
        {
            string name = "Hanan";
            //Assert.That(name, Is.Not.Null);
            Assert.That(name, Does.StartWith("H").And.EndsWith("n"));
        }
        [Test]
        public void Test_Boolen()
        {
            bool isActive = true;
            Assert.That(isActive, Is.True);
        }
        [Test]
        public void Test_Range()
        {
            int i = 50;
            Assert.That(i, Is.GreaterThan(30));
            Assert.That(i, Is.LessThan(100));
        }
    }
}
