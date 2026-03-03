using System.Collections.Generic;
using OpenIdentityServer;
using OpenIdentityServer.Models;

internal class Clients
{
    public static IEnumerable<Client> Get()
    {
        return
        [
            new Client
            {
                ClientId = "js",
                ClientName = "JavaScript Client",
                AllowedGrantTypes = GrantTypes.Code,
                RequireClientSecret = false,

                RedirectUris = { 
                    "https://localhost:3000/callback",
                    "https://localhost:3000/silent-renew" 
                },
                PostLogoutRedirectUris = { "https://localhost:3000/" },
                AllowedCorsOrigins =     { "https://localhost:3000" },
                AllowOfflineAccess = true,

                AllowedScopes =
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    IdentityServerConstants.StandardScopes.OfflineAccess,
                    "role",
                    "api1.read",
                    "api1.write",
                }
            }
        ];
    }
}