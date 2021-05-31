using API.CORE.DOMAIN.PasswordValidation.Interface;
using API.CORE.DOMAIN.PasswordValidation.Model;
using API.CORE.DOMAIN.PasswordValidation.Validation;
using System.Threading.Tasks;

namespace API.CORE.DOMAIN
{
    public class PasswordValidationBusiness : IPasswordValidation
    {
        // <summary>
        // method validates if a password contains a desired pattern 
        // </summary>
        // <return>
        // true or false for password and mesages show what is necessary
        // </return>
        public async Task<PasswordValidationModel> getPasswordValid(string password)
        {
            PasswordValidationValidator validator = new PasswordValidationValidator();
            var validation = validator.Validate(password);

            return new PasswordValidationModel()
            {
                isValid = validation.IsValid,
                Message = validation.ToString()
            };
        }
    }
}
