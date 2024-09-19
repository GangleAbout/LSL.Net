namespace LSL.Net.Errors;

/// <summary>
/// Lab Streaming Layer error codes.
/// </summary>
public enum ErrorCodes
{
    /// <summary>
    /// No error.
    /// </summary>
    NoError = 0,

    /// <summary>
    /// Operation timed out.
    /// </summary>
    TimeoutError = -1,

    /// <summary>
    /// Stream lost.
    /// </summary>
    LostError = -2,

    /// <summary>
    /// An argument was incorrectly specified. 
    /// </summary>
    ArgumentError = -3,

    /// <summary>
    /// Some other internal error has happened.
    /// </summary>
    /// <remarks>
    /// Not a particularly verbose error code
    /// but liblsl's <see href="https://github.com/sccn/liblsl/blob/7e61a2ef7a25a54b54968fb5c8776054f49b028e/include/lsl/common.h#L146-L147">docstring</see> says the same. 
    /// </remarks>
    InternalError = -4
}