using Xunit;

namespace IntroTdd.Test.Unit
{

    public class unitTest
    {
        [Fact]
        public void PassingTest()
        {
            Domain.DomainClass domainClass = new Domain.DomainClass();

            Assert.Equal(4, domainClass.Add(2, 2));
        }

        //[Fact]
        //public void FailingTest()
        //{
        //    Assert.Equal(5, Add(2, 2));
        //}

    }
}
