# NEW README

**OpenIdentityServer**

![Contributors](https://img.shields.io/github/contributors/2pNza/OpenIdentityServer?style=for-the-badge)
[![License: LGPL v3](https://img.shields.io/badge/License-LGPL%20v3-blue.svg?style=for-the-badge)](https://www.gnu.org/licenses/lgpl-3.0.html)
[![CLA Assistant](https://img.shields.io/badge/CLA%20Assistant-green?style=for-the-badge)](https://cla-assistant.io/2pNza/OpenIdentityServer)
![Version](https://img.shields.io/github/v/tag/2pNza/OpenIdentityServer?style=for-the-badge)
[![CI Status](https://img.shields.io/github/actions/workflow/status/2pNza/OpenIdentityServer/ci.yml?style=for-the-badge&label=CI)](https://github.com/2pNza/OpenIdentityServer/actions/workflows/ci.yml)



<img width="155" height="51" alt="image" src="https://www.gnu.org/graphics/lgplv3-147x51.png" />

## Bug reports and feature requests
Please use the [issue tracker](https://github.com/2pNza/OpenIdentityServer/issues) for that.

---

### NuGet Packages

| Package Name                                      | Badge                                                                                              |
|---------------------------------------------------|----------------------------------------------------------------------------------------------------|
| OpenIdentityServer                            | [![NuGet](https://img.shields.io/nuget/v/2pNza.OpenIdentityServer.svg?style=for-the-badge)](https://www.nuget.org/packages/2pNza.OpenIdentityServer/) |
| OpenIdentityServer.AspNetIdentity             | [![NuGet](https://img.shields.io/nuget/v/2pNza.OpenIdentityServer.AspNetIdentity.svg?style=for-the-badge)](https://www.nuget.org/packages/2pNza.OpenIdentityServer.AspNetIdentity/) |
| OpenIdentityServer.EntityFramework            | [![NuGet](https://img.shields.io/nuget/v/2pNza.OpenIdentityServer.EntityFramework.svg?style=for-the-badge)](https://www.nuget.org/packages/2pNza.OpenIdentityServer.EntityFramework/) |
| OpenIdentityServer.EntityFramework.Storage    | [![NuGet](https://img.shields.io/nuget/v/2pNza.OpenIdentityServer.EntityFramework.Storage.svg?style=for-the-badge)](https://www.nuget.org/packages/2pNza.OpenIdentityServer.EntityFramework.Storage/) |
| OpenIdentityServer.Storage                    | [![NuGet](https://img.shields.io/nuget/v/2pNza.OpenIdentityServer.Storage.svg?style=for-the-badge)](https://www.nuget.org/packages/2pNza.OpenIdentityServer.Storage/) |

---

The project is undergoing a renaming process and will be renamed to OpenIdentityServer

---
# OLD README

# Important notice
This is a fork of IdentityServer4 that is meant to keep existing software that depends on IdentityServer4 updated with the latest .NET framework version.

For a state of the art implementation, updates and innovations please use [Duende IdentityServer](https://duendesoftware.com/products/identityserver).

## Changes to IdentityServer4
Our goal is to keep any core changes to IdentityServer4 to a minimal so compatibility is maximized. Below you can find some of those changes in order to decide if they could affect your project:

* Api Resource Scopes can be used as Api Scopes: when validating a authorize request, IdentityServer4 validates scopes based on existing Api Resources and Api Scopes. We have 
updated this code to match requested scopes with Api Resource Scopes as well.

## About IdentityServer4
[<img align="right" width="100px" src="https://dotnetfoundation.org/img/logo_big.svg" />](https://dotnetfoundation.org/projects?searchquery=IdentityServer&type=project)

IdentityServer is a free, open source [OpenID Connect](http://openid.net/connect/) and [OAuth 2.0](https://tools.ietf.org/html/rfc6749) framework for ASP.NET Core.
Founded and maintained by [Dominick Baier](https://twitter.com/leastprivilege) and [Brock Allen](https://twitter.com/brocklallen), IdentityServer4 incorporates all the protocol implementations and extensibility points needed to integrate token-based authentication, single-sign-on and API access control in your applications.
IdentityServer4 is officially [certified](https://openid.net/certification/) by the [OpenID Foundation](https://openid.net) and thus spec-compliant and interoperable.
It is part of the [.NET Foundation](https://www.dotnetfoundation.org/), and operates under their [code of conduct](https://www.dotnetfoundation.org/code-of-conduct). It is licensed under [Apache 2](https://opensource.org/licenses/Apache-2.0) (an OSI approved license).

For project documentation, please visit [readthedocs](https://identityserver4.readthedocs.io).

## Branch structure
Active development happens on the main branch. This always contains the latest version. Each (pre-) release is tagged with the corresponding version.

## How to build

* [Install](https://www.microsoft.com/net/download/core#/current) the latest .NET 6 SDK
* Install Git
* Clone this repo
* Run `build.ps1` or `build.sh` in the root of the cloned repo

## Documentation
For project documentation, please visit [readthedocs](https://identityserver4.readthedocs.io).

## Help wanted
If you would like to contribute to this project feel free to use the issue tracker and/or submit Pull Requests.

## Acknowledgements
IdentityServer4 is built using the following great open source projects and free services:

* [ASP.NET Core](https://github.com/dotnet/aspnetcore)
* [Bullseye](https://github.com/adamralph/bullseye)
* [SimpleExec](https://github.com/adamralph/simple-exec)
* [MinVer](https://github.com/adamralph/minver)
* [Json.Net](http://www.newtonsoft.com/json)
* [XUnit](https://xunit.github.io/)
* [Fluent Assertions](http://www.fluentassertions.com/)
* [GitReleaseManager](https://github.com/GitTools/GitReleaseManager)
