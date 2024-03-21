using NUnit.Framework;

namespace UserService.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Assert.Pass("Your first passing test");
            Assert.Fail();
        }

        [Test]
        public void Test2()
        {
            Assert.Pass("Your first passing test");
        }
    }
}