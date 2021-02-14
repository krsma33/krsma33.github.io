using Microsoft.AspNetCore.Authorization;

namespace Rasadnik.Shared
{
    public class AuthPolicies
    {
        public const string Admin = "Admin";

        public static AuthorizationPolicy AdminPolicy()
        {
            return new AuthorizationPolicyBuilder().RequireAuthenticatedUser().RequireRole(Admin).Build();
        }
    }
}
