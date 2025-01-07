using DemoConsole;

namespace UnitTests
{

    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestAddEndpoint()
        {
            var result = Demo.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }

    }
}
