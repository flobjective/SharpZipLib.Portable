SharpZipLib.Portable
====================

SharpZipLib.Portable is a Portable Class Library version of the [\#ziplib](https://github.com/icsharpcode/SharpZipLib) a Zip, GZip, Tar and BZip2 library written entirely in C# for the .NET platform.

As PCL don't suppport cryptography nor System.IO, this library can't crypt/decrypt an archive, and all access to the file system are removed.

It works on .Net 4.5, Windows Phone 8.0/8.1, Windows Store 8.1, Xamarin.Android (MonoDroid), Xamarion.iOS (MonoTouch). 

Install
-------

Using Nuget Package : ```Install-Package SharpZipLib.Portable```.

Build
-------

[![Build status](https://ci.appveyor.com/api/projects/status/ifiq9bjs50h8nxxg/branch/master)](https://ci.appveyor.com/project/ygrenier/sharpziplib-portable/branch/master)

This library is build with [AppVeyor](https://ci.appveyor.com/project/ygrenier/sharpziplib-portable).
