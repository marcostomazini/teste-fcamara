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

            /// <summary>
            ///     Validacao do Token pelo web api e mvc
            /// </summary>
            /// <param name="protectedText"></param>
            /// <param name="purpose"></param>
            /// <returns></returns>
            public AuthenticationTicket Unprotect(string protectedText, string purpose)
            {
                try
                {
                    return new AuthenticationTicket(new System.Security.Claims.ClaimsPrincipal(), new AuthenticationProperties(), "Token");
                }
                catch (ArgumentException)
                {
                    return null;
                }

                return new AuthenticationTicket(new System.Security.Claims.ClaimsPrincipal(), new AuthenticationProperties(), "Cookie");
            }

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
