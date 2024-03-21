using NUnit.Framework;
using Microsoft.AspNetCore.Mvc;
using UserService.Controllers;
using UserService.Models;

namespace UserService.Test
{


    [TestFixture]
    public class RegisterControllerTests
    {
        [Test]
        public void Register_ShouldReturnSuccessMessage()
        {
            // Arrange
            var controller = new RegisterController();
            var user = new User
            {
                Username = "testuser",
                Email = "test@example.com",
                Password = "password123"
            };

            // Act
            var result = controller.Register(user);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result);
            var okResult = result as OkObjectResult;
            Assert.AreEqual($"User {user.Username} registered successfull.", okResult.Value);
        }
    }

}
