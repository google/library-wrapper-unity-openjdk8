# Library Wrapper Unity OpenJDK8 Library

[![openupm](https://img.shields.io/npm/v/com.google.librarywrapper.openjdk8?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.google.librarywrapper.openjdk8/)

[Library Wrapper](https://developer.android.com/games/develop/custom/wrapper) is
a code generator that parses Java API and produces wrapper APIs in Unity C#. It
does this by creating wrappers around every class in the Java API, handling the
details of JNI calls, signatures, and memory management.

This Unity package contains generated C# wrappers for a trimmed down version of
OpenJDK 8, consisting of `java.lang` and `java.util` classes. These wrappers
allow developers to access common Java data structures easily. This package is
an optional dependency for some Library Wrapper generated Unity packages.

## Installation

This package can be installed with
[OpenUPM](https://openupm.com/packages/com.google.librarywrapper.openjdk8/):

```shell
$ openupm add com.google.librarywrapper.openjdk8
```

This package can also be installed via the Unity Package Manager. See
[this guide](https://docs.unity3d.com/Manual/upm-ui-giturl.html) for details.

This package can be installed by downloading this repo and extract its content
to your project's `Packages/` folder
([embedded package](https://docs.unity3d.com/Manual/upm-ui-local.html)).

## How-tos

All the wrappers can be accessed by importing `Java.Lang` or `Java.Util`. All
methods and fields are renamed with CamelCase.

The [`Utils.cs`](Runtime/Utils.cs) file contains some extension methods that
converts data structures between Java and C#.
