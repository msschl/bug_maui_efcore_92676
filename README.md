The app can be run in debug and release mode with visual studio. 

However publishing the app as windows executable won't work and results in the issue described in [#92676](https://github.com/dotnet/runtime/issues/92676)

publish:
```sh
dotnet publish -f net8.0-windows10.0.19041.0 -p:WindowsPackageType=None MauiApp1\MauiApp1.csproj
```