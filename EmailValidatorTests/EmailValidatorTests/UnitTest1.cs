using Xunit;
using EmailValidatorApp;

namespace EmailValidatorTests
{
    public class EmailValidatorTests
    {
        [Theory]
        [InlineData("user@example.com")]
        [InlineData("ivan.petrov@mail.ru")]
        [InlineData("a.b+c@sub.domain.org")]
        [InlineData("test123@yandex.ru")]
        public void Test_ValidEmails_ReturnsTrue(string email)
        {
            Assert.True(EmailValidator.IsValidEmail(email));
        }

        [Theory]
        [InlineData("")]
        [InlineData("   ")]
        [InlineData("userexample.com")]
        [InlineData("user@")]
        [InlineData("@example.com")]
        [InlineData("user@example")]
        [InlineData("user@@example.com")]
        [InlineData("user example@mail.ru")]
        public void Test_InvalidEmails_ReturnsFalse(string email)
        {
            Assert.False(EmailValidator.IsValidEmail(email));
        }

        [Fact]
        public void Test_NullEmail_ReturnsFalse()
        {
            Assert.False(EmailValidator.IsValidEmail(null));
        }

        [Fact]
        public void Test_EmailWithSpacesAround_ReturnsTrue()
        {
            Assert.True(EmailValidator.IsValidEmail("  user@example.com  "));
        }
    }
}