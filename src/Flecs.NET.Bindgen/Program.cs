﻿using System.Diagnostics;
using System.Runtime.CompilerServices;
using Bindgen.NET;

BindingOptions bindingOptions = new()
{
    Namespace = "Flecs.NET.Bindings",
    Class = "flecs",

    DllImportPath = "flecs",

    DllFilePaths =
    {
        "flecs",
        "libflecs",
        "runtimes/linux-x64/native/libflecs",
        "runtimes/linux-arm64/native/libflecs",
        "runtimes/osx-x64/native/libflecs",
        "runtimes/osx-arm64/native/libflecs",
        "runtimes/win-x64/native/flecs",
        "runtimes/win-arm64/native/flecs"
    },

    SuppressedWarnings = { "CS8981" },

    IncludeBuiltInClangHeaders = true,

    InputFile = GetFlecsHeaderPath(),
    OutputFile = GetBindingsOutputPath(),

    GenerateMacros = true,
    GenerateExternVariables = true,
    GenerateStructEqualityFunctions = true
};

if (OperatingSystem.IsMacOS())
    bindingOptions.SystemIncludeDirectories.Add(GetMacOsHeaders());

BindingGenerator.Generate(bindingOptions);

string GetFlecsHeaderPath([CallerFilePath] string filePath = "")
{
    return Path.GetFullPath(Path.Combine(filePath, "..", "..", "..", "submodules", "flecs", "flecs.h"));
}

string GetBindingsOutputPath([CallerFilePath] string filePath = "")
{
    return Path.GetFullPath(Path.Combine(filePath, "..", "..", "Flecs.NET.Bindings", "Flecs.g.cs"));
}

string GetMacOsHeaders()
{
    using Process process = new()
    {
        StartInfo = new ProcessStartInfo
        {
            FileName = "xcrun",
            Arguments = "--sdk macosx --show-sdk-path",
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        }
    };

    process.Start();
    process.WaitForExit();

    string path = process.StandardOutput.ReadToEnd().Trim();

    if (!Directory.Exists(path))
        throw new DirectoryNotFoundException("Couldn't find system headers. Install XCode.");

    return path + "/usr/include";
}
