VL.NativePluginTest
===========================
![img](https://i.imgur.com/AYkZrio.png)
This is a test project that show how to written native plugin for vvvv gamma using c++ and wsl.

Require
---------------------------
- .NET SDK(using [.NET Standerd 2.0](https://thegraybook.vvvv.org/reference/extending/writing-nodes.html))
- WSL(Ubuntu)
  - make `sudo apt install make`
  - mingw-w64 `sudo apt install mingw-w64`

How to build plugin
---------------------------
Copy the various assemblies to `src/lib` to use the Stride API.
  - Stride.dll
  - Stride.Core.dll
  - Stride.Rendering.dll
  - Stride.Graphics.dll  

and run `src/build.sh` on wsl console.