using System;
using System.Collections.Generic;
using System.Text;

namespace API.CORE.DOMAIN.PasswordValidation.Model
{
    public class PasswordValidationModel
    {
        public bool isValid { get; set; }

        public string Message { get; set; }
    }
}
