using Newtonsoft.Json;
using NUnit.Framework;
using Project.Model;
using System.Collections;
using UnitTest_nunit.DataDTO;

namespace UnitTest_nunit.Advanced
{
    [TestFixture]
    public class EmployeeTest
    {
        private Employee employee;
        [SetUp]
        public void Setup()
        {
            employee = new Employee();
        }

        //[Test]
        //public void checkEmployeeIsSeniorCitizen_LessThan60()
        //{
        //    var result = employee.IsSeniorCitizen(50);
        //    Assert.That(result, Is.False);
        //}
        //[Test]
        //public void checkEmployeeIsSeniorCitizen_GreaterThan60()
        //{
        //    var result = employee.IsSeniorCitizen(70);
        //    Assert.That(result, Is.True);
        //}

        [Test]
        [TestCase(50, ExpectedResult = false)]
        [TestCase(70, ExpectedResult = true)]
        [TestCase(80, ExpectedResult = true)]
        [TestCase(90, ExpectedResult = true)]
        [TestCase(100, ExpectedResult = true)]
        public bool checkIsSenorOrNot(int age)
        {
            return employee.IsSeniorCitizen(age);
        }

        [Test]
        [Sequential]
        public void checkIsSenorOrNotUsingArrayValues([Values(50, 60, 70)] int age, [Values(false, true, true)] bool expectedValue)
        {
            var res = employee.IsSeniorCitizen(age);
            Assert.That(res, Is.EqualTo(expectedValue));
        }



        [Test]
        [Sequential]
        public void checkIsSenorOrNotUsingRandomValues([Random(20, 100, 10, Distinct = true)] int age, [Values(false)] bool expectedValue)
        {
            var res = employee.IsSeniorCitizen(age);
            Assert.That(res, Is.EqualTo(expectedValue));
        }


        [Test]
        [TestCaseSource(typeof(TestData))]
        public bool checkIsSenorOrNotUsingYeild(int age)
        {
            return employee.IsSeniorCitizen(age);
        }


        [Test]
        [TestCaseSource(typeof(TestData2))]
        public bool checkIsSenorOrNotUsingJsonFile(int age)
        {
            return employee.IsSeniorCitizen(age);
        }



        // using test case source

        public class TestData : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new TestCaseData(50).Returns(false);
                yield return new TestCaseData(70).Returns(true);
                yield return new TestCaseData(80).Returns(true);
                yield return new TestCaseData(90).Returns(true);
                yield return new TestCaseData(100).Returns(true);
            }
        }
        public class TestData2 : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                var json = File.ReadAllText("EmployeeData.json");

                List<EmployeeTestCaseData> items = JsonConvert.DeserializeObject<List<EmployeeTestCaseData>>(json);

                foreach (var data in items)
                {
                    yield return new TestCaseData(data.age).Returns(data.expectedResult);
                }
            }
        }




    }
}
