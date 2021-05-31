using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace API.CORE.DOMAIN.PasswordValidation.Validation
{
    public class PasswordValidationValidator : AbstractValidator<string>
    {
        public PasswordValidationValidator()
        {
            RuleFor(pass => pass)
                .Length(9, 100).WithMessage("Senha deve conter 9 ou mais caracteres.")
                .Matches("[0-9]").WithMessage("Senha deve conter ao menos 1 dígito númerico.")
                .Must(getAnyLowerCase).WithMessage("Senha deve conter ao menos 1 letra minúscula.")
                .Must(getAnyUpperCase).WithMessage("Senha deve conter ao menos 1 letra maiúscula.")
                .Must(getHaveSpace).WithMessage("A senha não deve conter espaços.")
                .Matches("[!@#$%^&*()-+]").WithMessage("Senha deve conter ao menos 1 caractere especial.")
                .Must(getRepetChar).WithMessage("Senha não deve possuir caracteres repetidos dentro do conjunto.");
        }

        // <summary>
        // method validates have any character with lower case
        // </summary>
        // <return>
        // true or false 
        // </return>
        private static bool getAnyLowerCase(string password)
        {
            return password.Any(ch => char.IsLower(ch));
        }

        // <summary>
        // method validates have any character with upper case
        // </summary>
        // <return>
        // true or false 
        // </return>
        private static bool getAnyUpperCase(string password)
        {
            return password.Any(ch => char.IsUpper(ch));
        }

        // <summary>
        // method validates have any space on the text
        // </summary>
        // <return>
        // true or false 
        // </return>
        private static bool getHaveSpace(string password)
        {
            return password.IndexOf(" ") < 0;
        }

        // <summary>
        // method validates if text repet same character
        // </summary>
        // <return>
        // true or false 
        // </return>
        private static bool getRepetChar(string password)
        {
            var result = password.ToUpper().GroupBy(o => o).FirstOrDefault(o => o.Count() > 1);
            
            return result == null;
        }
    }
}
