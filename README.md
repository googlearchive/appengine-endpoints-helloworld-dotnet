appengine-endpoints-helloworld-dotnet
======================================

This application implements a simple client for a hello world sample using Google Cloud Endpoints, App Engine and Windwos Phone.

It relies on [Google APIs client library for .NET][1]

This example also uses [Google.Apis][2] and [Google.Apis.Auth][3] NuGet packages.

## Products
- [App Engine][4]

## Language
- [C#][5]

## APIs
- [Google Cloud Endpoints for Windows Phone][6]

## Setup Instructions
1. Open `HelloWorld.sln` in Visual Studio
2. Modify `ClientId` and `ClientSecrets` in `ClientSecretsConsts.cs` to include
   the installed client ID and client secret you registered in the [Google Developers Console][7].
3. Run the [Hello World java backend example][8].
4. Run the application.


[1]: https://developers.google.com/api-client-library/dotnet
[2]: http://www.nuget.org/packages/Google.Apis/
[3]: http://www.nuget.org/packages/Google.Apis.Auth/
[4]: https://developers.google.com/appengine/
[5]: http://msdn.microsoft.com/en-us/library/618ayhy6(v=vs.71).aspx
[6]: https://devsite.googleplex.com/appengine/docs/java/endpoints/consume_wp
[7]: https://console.developers.google.com
[8]: https://github.com/GoogleCloudPlatform/appengine-endpoints-helloendpoints-java-maven
