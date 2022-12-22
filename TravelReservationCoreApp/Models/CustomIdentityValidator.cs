using Microsoft.AspNetCore.Identity;

namespace TravelReservationCoreApp.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = "PasswordTooShort",
                Description=$"Parola minimum {length} karakter olmalıdır."
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresUpper",
                Description = $"Parola En Az 1 Büyük Karakter İçermelidir."
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresLower",
                Description = $"Parola En Az 1 Küçük Karakter İçermelidir."
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = $"Parola En Az 1 Sembol Karakter İçermelidir."
            };
        }

    }
}
