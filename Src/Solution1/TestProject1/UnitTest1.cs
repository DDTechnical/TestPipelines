using Xunit;
using MyNamespace;

namespace MyNamespace.Tests
{
    public class MyClassTests
    {
        [Fact]
        public void TestAdd()
        {
            MyClass myClass = new MyClass();
            int result = myClass.Add(2, 3);
            Assert.Equal(5, result);
        }
    }
}
