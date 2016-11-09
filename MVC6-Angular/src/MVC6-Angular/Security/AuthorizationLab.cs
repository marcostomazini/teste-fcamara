using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angle_MVC6_Angular_Seed.Security
{
    public class AuthorizationLab
    {
        public class TokenRequirement : ISecureDataFormat<AuthenticationTicket>
        {
            public TokenRequirement()
            {
            }

            public AuthenticationTicket Unprotect(string protectedText)
                => Unprotect(protectedText, null);

            public AuthenticationTicket Unprotect(string protectedText, string purpose)
            {
                try
                {
                    // Additional custom validation of JWT claims here (if any)
                }
                catch (ArgumentException)
                {
                    return null;
                }

                // Validation passed. Return a valid AuthenticationTicket:
                return new AuthenticationTicket(new System.Security.Claims.ClaimsPrincipal(), new AuthenticationProperties(), "Cookie");
            }

            // This ISecureDataFormat implementation is decode-only
            public string Protect(AuthenticationTicket data)
            {
                throw new NotImplementedException();
            }

            public string Protect(AuthenticationTicket data, string purpose)
            {
                throw new NotImplementedException();
            }
        }
    }
}
