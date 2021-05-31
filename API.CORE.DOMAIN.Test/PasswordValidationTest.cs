using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;

namespace API.CORE.DOMAIN.Test
{
    [TestClass]
    public class PasswordValidationTest
    {
        [TestMethod]
        public void EmptyValue()
        {
            var pass = new PasswordValidationBusiness().getPasswordValid(string.Empty);

            Assert.IsTrue(!pass.isValid);
        }

        [TestMethod]
        public void LessNineCharacters()
        {
            var pass = new PasswordValidationBusiness().getPasswordValid("AbTp9!fo");

            Assert.IsTrue(!pass.isValid);
        }

        [TestMethod]
        public void DontHaveLowerCase()
        {
            var pass = new PasswordValidationBusiness().getPasswordValid("ABTP9!FOK");

            Assert.IsTrue(!pass.isValid);
        }

        [TestMethod]
        public void DontHaveUpperCase()
        {
            var pass = new PasswordValidationBusiness().getPasswordValid("abtp9!fok");

            Assert.IsTrue(!pass.isValid);
        }

        [TestMethod]
        public void HaveSpace()
        {
            var pass = new PasswordValidationBusiness().getPasswordValid("Ab Tp9!fok");

            Assert.IsTrue(!pass.isValid);
        }

        [TestMethod]
        public void DontHaveSpecialCharacter()
        {
            var pass = new PasswordValidationBusiness().getPasswordValid("AbTp9fok");

            Assert.IsTrue(!pass.isValid);
        }

        [TestMethod]
        public void DuplicateCharacter()
        {
            var pass = new PasswordValidationBusiness().getPasswordValid("AbTp9!fokB");

            Assert.IsTrue(!pass.isValid);
        }

        [TestMethod]
        public void DontHaveNumbers()
        {
            var pass = new PasswordValidationBusiness().getPasswordValid("AbTp!fokB");

            Assert.IsTrue(!pass.isValid);
        }

        [TestMethod]
        public void CorrectPassword()
        {
            var pass = new PasswordValidationBusiness().getPasswordValid("AbTp9!fok");

            Assert.IsTrue(pass.isValid);
        }

    }
}
