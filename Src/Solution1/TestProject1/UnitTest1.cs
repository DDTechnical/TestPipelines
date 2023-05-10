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
            int result = myClass.Add(3, 4);
            Assert.Equal(7, result);
        }
    }
}
