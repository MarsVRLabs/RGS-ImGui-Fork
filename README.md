# Dear ImGui for Unity

This is an internal fork of [RGS's package](https://github.com/realgamessoftware/dear-imgui-unity) for the immediate mode GUI library, Dear ImGui (https://github.com/ocornut/imgui).
The major changes are an updated ImGui version with ImGui internals support, a ton of bug fixes, hybrid input system support, and ImPlot support.
We use this in our flagship software [MARS VR XPod](https://marsvrlab.com/mars-vr-xpod/). 

Please check the original project for usage info, and install info. TLDR: download this package, unzip in your packages folder on unity.

This package uses Dear ImGui C bindings by [cimgui](https://github.com/cimgui/cimgui) for both ImGui and ImPlot, and the C# wrapper by [Mellinoe](https://github.com/mellinoe/ImGui.NET). 
We also use some code from Psydack's [wonderful updated version](https://github.com/psydack/uimgui) for fixing a specific submesh warning. If you don't need any features from our package, we highly recommend using his instead.

We cannot confirm support for new features and bug fixes, but we feel like we should share what we have with the community, even if it's far from perfect.
