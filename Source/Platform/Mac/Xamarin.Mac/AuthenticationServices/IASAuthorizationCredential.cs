using System;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "ASAuthorizationCredential", WrapperType = typeof(ASAuthorizationCredentialWrapper))]
public interface IASAuthorizationCredential : INativeObject, IDisposable, INSCoding, INSCopying, INSSecureCoding
{
}
