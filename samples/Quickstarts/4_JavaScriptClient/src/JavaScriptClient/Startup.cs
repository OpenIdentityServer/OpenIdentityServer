// SPDX-License-Identifier: Apache-2.0

using Microsoft.AspNetCore.Builder;

namespace JavaScriptClient
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();
        }
    }
}
