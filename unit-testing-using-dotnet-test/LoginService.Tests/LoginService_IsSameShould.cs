using Xunit;
using Login.Services;

namespace Login.UnitTests.Services
{
    public class LoginService_IsSameShould
    {
        [Fact]
        public void IsLogin_InputIs1_ReturnFalse()
        {
            var loginService = new LoginService();
            bool result = loginService.IsLogin(1);

            Assert.False(result, "Username does not exist.");
        }
    }
}