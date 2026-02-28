// SPDX-License-Identifier: Apache-2.0

﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace migrations
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
