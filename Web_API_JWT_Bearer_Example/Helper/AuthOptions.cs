using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_API_JWT_Bearer_Example.Helper
{
    public class AuthOptions
    {
        public const string ISSUER = "MyAuthServer"; // Token creator
        public const string AUDIENCE = "http://localhost:51884/"; // Token consumer
        const string KEY = "my_ecret_key_123"; // key for encryption
        public const int LIFETIME = 1; // lifetime of the token in minutes
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {            
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
