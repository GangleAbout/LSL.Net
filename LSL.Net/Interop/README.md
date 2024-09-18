# Interop Generation Instructions

Run the code snippets in a PowerShell window from the root of this repository.

1. Install `ClangSharpPInvokeGenerator`
    ```ps
    dotnet tool install --global ClangSharpPInvokeGenerator
    ```

2. Install matching clang version
    ```ps
    ClangSharpPInvokeGenerator -v
    winget install LLVM.LLVM --version <ClangSharpVersion> 
    ```

3. Generate `Common.g.cs`
    1. Generate code
       ```ps
       ClangSharpPInvokeGenerator `
       --config latest-codegen generate-file-scoped-namespaces generate-helper-types generate-macro-bindings log-visited-files multi-file `
       --file .\liblsl\include\lsl_c.h `
       --traverse .\liblsl\include\lsl\common.h `
       --libraryPath lsl `
       --methodClassName LSL `
       --with-access-specifier *=internal `
       --namespace LSL.Net.Interop `
       --output .\LSL.Net\Interop `
       --include-directory "C:\Program Files\LLVM\lib\clang\18\include\" `
       --exclude lsl_channel_format_t lsl_processing_options_t lsl_error_code_t lsl_transport_options_t `
       --remap sbyte*=IntPtr      
       ```
    2. Change file names
       ```ps
       Move-Item -Path .\LSL.Net\Interop\LSL.cs -Destination .\LSL.Net\Interop\Common.cs
       Move-Item -Path .\LSL.Net\Interop\NativeAnnotationAttribute.cs -Destination .\LSL.Net\Interop\NativeAnnotationAttribute.g.cs
       Move-Item -Path .\LSL.Net\Interop\NativeTypeNameAttribute.cs -Destination .\LSL.Net\Interop\NativeTypeNameAttribute.g.cs
       ```
    3. Fix [SYSLIB1054](https://learn.microsoft.com/en-gb/dotnet/fundamentals/syslib-diagnostics/syslib1050-1069) by
       using IDE (_Rider_) to convert to `LibraryImportAttribute` from `DllImportAttribute`
    4. Change name of file to `Common.g.cs` to indicate that it is a 'generated' file. _Note: To stop IDE from
       complaining e.g. about naming conventions_
       ```ps
       Move-Item -Path .\LSL.Net\Interop\Common.cs -Destination .\LSL.Net\Interop\Common.g.cs
       ```



