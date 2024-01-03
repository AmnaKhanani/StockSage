using NUnit.Framework;
using static InventorySystemCsharp.Login;

[TestFixture]
public class LoginTests
{
    [Test]
    public void SuccessfulLogin()
    {
        // Arrange
        string username = "validUser";
        string password = "validPassword";
        LoginService loginService = new LoginService();

        // Act
        bool result = loginService.Login(username, password);

        // Assert
        Assert.IsTrue(result, "Login should be successful with valid credentials");
    }

    [Test]
    public void UnsuccessfulLogin()
    {
        // Arrange
        string username = "invalidUser";
        string password = "invalidPassword";
        LoginService loginService = new LoginService();

        // Act
        bool result = loginService.Login(username, password);

        // Assert
        Assert.IsFalse(result, "Login should be unsuccessful with invalid credentials");
    }
}



