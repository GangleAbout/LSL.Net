using System.Runtime.InteropServices;
// ReSharper disable CommentTypo
// ReSharper disable IdentifierTypo
// ReSharper disable StringLiteralTypo

namespace LSL.Net.Interop;

internal static partial class LSL
{
    [LibraryImport("lsl")]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    [return: NativeTypeName("const char *")]
    public static partial IntPtr lsl_last_error();

    [LibraryImport("lsl")]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    [return: NativeTypeName("int32_t")]
    public static partial int lsl_protocol_version();

    [LibraryImport("lsl")]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    [return: NativeTypeName("int32_t")]
    public static partial int lsl_library_version();

    [LibraryImport("lsl")]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    [return: NativeTypeName("const char *")]
    public static partial IntPtr lsl_library_info();

    [LibraryImport("lsl")]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    public static partial double lsl_local_clock();

    [LibraryImport("lsl")]
    [UnmanagedCallConv(CallConvs = new Type[] { typeof(System.Runtime.CompilerServices.CallConvCdecl) })]
    public static partial void lsl_destroy_string([NativeTypeName("char *")] IntPtr s);

    [NativeTypeName("#define LSL_IRREGULAR_RATE 0.0")]
    public const double LSL_IRREGULAR_RATE = 0.0;

    [NativeTypeName("#define LSL_DEDUCED_TIMESTAMP -1.0")]
    public const double LSL_DEDUCED_TIMESTAMP = -1.0;

    [NativeTypeName("#define LSL_FOREVER 32000000.0")]
    public const double LSL_FOREVER = 32000000.0;

    [NativeTypeName("#define LSL_NO_PREFERENCE 0")]
    public const int LSL_NO_PREFERENCE = 0;

    [NativeTypeName("#define LIBLSL_COMPILE_HEADER_VERSION 114")]
    public const int LIBLSL_COMPILE_HEADER_VERSION = 114;
}