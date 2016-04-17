using Xunit;

namespace BasicAspNet.Test
{
	public class XunitTest
	{
                [Fact]
                public void PassingTest()
                {
                Assert.Equal(4, Add(2, 2));
                }
                public void PassingTest2()
                {
                Assert.Equal(4, Add(2, 2));
                }
                [Fact]
                public void FailingTest()
                {
                Assert.Equal(5, Add(2, 2));
                }
                [Fact]
                public void FailingTest2()
                {
                Assert.Equal(5, Add(2, 2));
                }
        
                int Add(int x, int y)
                {
                return x + y;
                }
	}
}