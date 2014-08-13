SharpZipLib.Portable
====================

SharpZipLib.Portable is a Zip, GZip, Tar and BZip2 library written entirely in C# for the .NET Portable Class Library.

This library is based on the [\#ziplib](https://github.com/icsharpcode/SharpZipLib) a Zip, GZip, Tar and BZip2 library written entirely in C# for the .NET platform.

As PCL don't suppport cryptography nor System.IO, this library can't crypt/decrypt an archive, and all access to the file system are removed.
