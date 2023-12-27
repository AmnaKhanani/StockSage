//using NUnit.Framework;
//using static InventorySystemCsharp.Login;

//[TestFixture]
//public class LoginTests
//{
//    [Test]
//    public void SuccessfulLogin()
//    {
//        // Arrange
//        string username = "validUser";
//        string password = "validPassword";
//        LoginService loginService = new LoginService();

//        // Act
//        bool result = loginService.Login(username, password);

//        // Assert
//        Assert.IsTrue(result, "Login should be successful with valid credentials");
//    }

//    [Test]
//    public void UnsuccessfulLogin()
//    {
//        // Arrange
//        string username = "invalidUser";
//        string password = "invalidPassword";
//        LoginService loginService = new LoginService();

//        // Act
//        bool result = loginService.Login(username, password);

//        // Assert
//        Assert.IsFalse(result, "Login should be unsuccessful with invalid credentials");
//    }
//}


using InventorySystemCsharp;
using NUnit.Framework;

[TestFixture]
public class LoginTests
{
    private const string V = "invalid credentials";

    public object MessageBox { get; private set; }

    [Test]
    public void Login_SuccessfulMemberLogin_ReturnsHome()
    {
        // Arrange
        var loginForm = new Login();

        // Act
        loginForm.bunifuMetroTextbox1.Text = "admin";  // Replace with an existing member username
        loginForm.bunifuMetroTextbox2.Text = "password123";  // Replace with the corresponding password

        loginForm.bunifuFlatButton1.PerformClick();

        // Assert
        Assert.IsInstanceOf<Home>(loginForm.ActiveMdiChild);
    }

    [Test]
    public void Login_UnsuccessfulLogin_ReturnsMessageBox()
    {
        // Arrange
        var loginForm = new Login();

        // Act
        loginForm.bunifuMetroTextbox1.Text = "nonexistentUsername";  // Replace with a non-existing username
        loginForm.bunifuMetroTextbox2.Text = "invalidPassword";      // Replace with an invalid password

        loginForm.bunifuFlatButton1.PerformClick();

        // Assert
        // Check if a message box is displayed indicating unsuccessful login
        Assert.IsTrue(V);
       
    }
}
