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
            int result = myClass.Add(2, 4);
            Assert.Equal(6, result);
        }
    }
}
