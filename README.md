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
1. Open `TicTacToeSample.xcodeproj` in Xcode.
2. Modify `kMyClientId` and `kMyClientSecret` in `ViewController.m` to include
   the web client ID and client secret you registered in the [APIs Console][6].
3. Modify `GTLServiceTictactoe.m` (line 44) to point to the location where you
   are hosting a Tic Tac Toe backend (based off of the
   [Java backend example][7]).
4. Run the application.


[1]: https://developers.google.com/api-client-library/dotnet
[2]: http://www.nuget.org/packages/Google.Apis/
[3]: http://www.nuget.org/packages/Google.Apis.Auth/
[4]: https://developers.google.com/appengine/
[5]: http://msdn.microsoft.com/en-us/library/618ayhy6(v=vs.71).aspx
[6]: https://devsite.googleplex.com/appengine/docs/java/endpoints/consume_wp
