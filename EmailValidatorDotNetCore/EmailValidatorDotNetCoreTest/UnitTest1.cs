using EmailValidatorDotNetCore;
using Xunit;

namespace EmailValidatorDotNetCoreTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var validator = new EmailValidator();
            Assert.False(validator.Validate("iren@saltaliiiiiii.com").Result);
            Assert.True(validator.Validate("iren@saltali.com").Result);
        }
    }
}
