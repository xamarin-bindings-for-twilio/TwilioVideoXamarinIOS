# Twilio Video Xamarin IOS

Twilio Video iOS SDK binding for Xamarin

[![NuGet][nuget-img]][nuget-link]

[nuget-img]: https://img.shields.io/badge/nuget-4.4.0-blue.svg
[nuget-link]: https://www.nuget.org/packages/Twilio.Video.XamarinBinding

## How to Build

### Twilio.Video iOS 4.4.0 (March 31, 2021)
```
sh bootstrapper.sh
```

Add --registrar:static as additional mtouch arguments on iOS Build dialog for your iOS application.
Sometimes adding -cxx is also required.

## Sample

####  I don't have C# version of twilio quickstart application, so I highly recommend you to read about using native library bindings for xamarin and check official Twilio quickstart guides.

[delegate sample](sample)

[voice-quickstart-swift](https://github.com/twilio/video-quickstart-ios)

## Contributions

Members of the community have contributed to improving and update bindings:

- [MKGNZ](https://github.com/MKGNZ)
- [4brunu](https://github.com/4brunu)

If you have a bugfix or an update you'd like to add, please open an issue. 
All pull requests should be opened against the `master` branch.
