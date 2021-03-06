# Hololens.DevicePortal Apis
Simple C# project that accesses the Hololens Device portal REST APIs.

~~This project is essentially dead for the time being.~~ (Ehhh, I'll update it...) I started it up when early documentation and tooling for the Hololens was limited or not yet complete. But, that issue has been resolved since I started this. ~~I essentially abandoned this project when I saw MS was creating the same thing~~

Microsoft's version:(https://github.com/Microsoft/WindowsDevicePortalWrapper).

Currently updating to .NET Standard 2.0, fixing a ton of stupid "I'm learning async/await" from years ago, and I'll see if I can get this working in Unity 2017 now that they support newer .Net versions.

## Quick summary:
The Hololens has a built-in interface (Device Portal) that is accessible by a browser. Using the excellent [Charles Reverse Proxy](https://www.charlesproxy.com/documentation/welcome/), I had scraped the Websocket/HTTPS calls/payloads that were being made from the browser to the Hololens. Reverse engineering from that, we have this C# library that essentially worked as the browser would have, and does the calls itself. The final goal is to allow cross-platform C# applications to remotely control a Hololens, or to pull data in real-time from one or more Hololens devices.

The API surface of this library is rough, as I'm mimicing the HTTPS paths directly in how the C# class hierarchy is laid out. The plan is for a cleaner API to come in later.

There is a decent amount of reverse engineering done on some of the 3d primitives, so that might be of some interest to folks. As well as a handful of JSON.Net JsonConverters for some of the JSON payloads.

This is not complete, nor can I vouch for what is there actually working or won't harm your Hololens.
