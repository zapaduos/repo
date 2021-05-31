using API.CORE.DOMAIN.PasswordValidation.Model;
using System.Threading.Tasks;

namespace API.CORE.DOMAIN.PasswordValidation.Interface
{
    public interface IPasswordValidation
    {
        Task<PasswordValidationModel> getPasswordValid(string password);
    }
}
