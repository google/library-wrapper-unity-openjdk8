# Library Wrapper Unity OpenJDK8 Library

[Library Wrapper](https://developer.android.com/games/develop/custom/wrapper) is
a code generator that parses Java API and produces wrapper APIs in Unity C#. It
does this by creating wrappers around every class in the Java API, handling the
details of JNI calls, signatures, and memory management.

This Unity package contains generated C# wrappers for a trimmed down version of
OpenJDK 8, consisting of `java.lang` and `java.util` classes. These wrappers
allow developers to access common Java data structures easily. This package is
an optional dependency for some Library Wrapper generated Unity packages.

## Installation

This package can be installed from the Unity Package Manager. See
[this guide](https://docs.unity3d.com/Manual/upm-ui-giturl.html) for details.

This package can be installed by downloading this repo and extract its content
to your project's `Packages/` folder
([embedded package](https://docs.unity3d.com/Manual/upm-ui-local.html)).

We are working to support this package on OpenUPM.

## Use

All the wrappers can be accessed by importing `Java.Lang` or `Java.Util`. All
methods and fields are renamed with CamelCase.

The [`Utils.cs`](Runtime/Utils.cs) file contains some extension methods that
converts data structures between Java and C#.
