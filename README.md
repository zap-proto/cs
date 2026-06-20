# zap-dotnetcore [![Build status](https://ci.appveyor.com/api/projects/status/tx4jjl2etiqve2xg/branch/master?svg=true)](https://ci.appveyor.com/project/zap-proto/cs/branch/master) [![Coverage Status](https://coveralls.io/repos/github/zap-proto/cs/badge.svg)](https://coveralls.io/github/zap-proto/cs)

> **Docs:** [ZAP .NET / C# SDK](https://zap-proto.dev/docs/sdks/csharp) · part of the [ZAP Protocol](https://zap-proto.io)


A ZAP implementation for .NET Standard 2.0 (credits to [lostinplace](https://github.com/lostinplace)) and .NET Core.

["ZAP is an insanely fast data interchange format and capability-based RPC system."](https://zap-proto.dev/) Whilst the original implementation is written in C++ there are several ports to other languages. This is a C# implementation for .NET Core.

Disclaimer: Neither this project nor its author are affiliated with ZAP. This is just yet another independent implementation of the specification. The following sections assume that you are familiar with [ZAP](https://zap-proto.dev/) and probably its [GitHub project](https://github.com/zap-proto/cs).

## Getting started: Users

The overall deployment consists of two components:
- The C# code generator back end is required for generating `.cs` serialization classes from `.zap` schema files. It is designed to be used in conjunction with the ZAP tool set which is maintained at the original site. The tool set is required at compile time.
- The `Zap.Net.Runtime` assembly is to be included as a reference into your particular application (or assembly).

### Code generator back end: Visual Studio / MSBuild integration

This is probably the most convenient option for Visual Studio development: The MSBuild integration package recognizes `.zap` files in your VS project and generates their code-behind during build.

A prerequisite is that the ZAP tool suite is installed (`zap.exe` must be on your `PATH`). The simplest way to achieve this:
```
choco install zap
```

Then, for the VS project which hosts your `.zap` schema definitions:

```
Install-Package ZapC.CSharp.MsBuild.Generation
```

### Code generator back end: dotnet tool

The C# code generator back end is available as dotnet tool. It requires a .NET Core 3.1 (or higher) runtime or SDK (type `dotnet` at command line prompt to check whether you already have one). This is the recommended variant. To install it globally, type

```
dotnet tool install zapc-csharp --global
```

### Code generator back end: Windows command line

There is also a self-contained [Chocolatey](https://chocolatey.org/) deployment for Windows (x86). To install, type

```
choco install zapc-csharp-win-x86
```

This variant will also download and install the [ZAP tool set Chocolatey package](https://www.chocolatey.org/packages/zap). Note that the author does not maintain this package and has no influence on its contents.

### Runtime assembly

The `Zap.Net.Runtime` assembly is available as [Nuget package](https://www.nuget.org/packages?q=Zap.Net.Runtime). E.g. within VS package manage console, type

```
Install-Package Zap.Net.Runtime
```

## Getting started: Developers

For building from scratch you will need Visual Studio ≥ 2019 (e.g. Community Edition) with suitable workloads for C# / .NET Core (currently .NET Core 2.1) development. For the test suite, you will also need the C++ native workload, [vcpkg](https://github.com/microsoft/vcpkg) and ZAP release 0.7.0:

```
vcpkg install zap
```

Solution/project structure is as follows:
- `Zap.Net.sln` contains these projects:
  * `Zap.Net.Runtime` is the runtime implementation, a multi-target assembly.
  * `ZapC.CSharp.Generator` contains the generator backend logic for C# language. It is also a multi-target (.NET Standard 2.0 + .NET Core 2.1) assembly.
  * `zapc-csharp` is the command line-based generator backend (a .NET Core 2.1 application).
  * `ZapC.CSharp.MsBuild.Generation` provides the MSBuild integration for the generator backend.
  * `Zap.Net.Runtime.Tests` is an MS test assembly, containing - you guessed it - the test suite.
  * `ZapC.CSharp.Generator.Tests` contains the generator backend test suite.
  * `ZapC.CSharp.MsBuild.Generation.Tests` contains tests for `ZapC.CSharp.MsBuild.Generation`.
- `ZapCompatTest.sln` compiles to a native x86 executable which depends on the original ZAP C++ implementation. It is (partially) required by the test suite for interoperability testing.
- `MsBuildGenerationTest\MsBuildGenerationTest.sln` is a test solution/project for MSBuild integration.

## Features

The following ZAP features are currently implemented:
- Serialization/deserialization of all kinds of data (structs, groups, unions, lists, capabilities, data, text, enums, even primitives)
- Generics
- Level 1 RPC, including promise pipelining, embargos, and automatic tail calls
- Security (pointer validation, protection against amplification and stack overflow DoS attacks)
- Compiler backend generates reader/writer classes, interfaces, proxies, skeletons (as you know it from the C++ implementation), and additionally so-called "domain classes" for all struct types. A domain class is like a "plain old C# class" for representing a schema-defined struct, but it is decoupled from any underlying message. It provides serialize/deserialize methods for assembling/disassembling the actual message. This provides more convenience, but comes at the price of non-zero serialization overhead (not "infinitely" faster anymore).

These features are not yet implemented:
- Level N RPC with N ≥ 2
- Packing
- Compression
- Canonicalization
- Dynamic Reflection
- mmap