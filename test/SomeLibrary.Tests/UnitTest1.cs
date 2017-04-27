using Xunit;
using Shouldly;

namespace SomeLibrary
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
          var someClass = new Class1();

          someClass.One().ShouldBe(1);
        }
    }
}
