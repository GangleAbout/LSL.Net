namespace LSL.Net.Options;

/// <summary>
/// Data format of the channels within a Lab Streaming Layer stream 
/// </summary>
public enum ChannelFormat
{
    /// <summary>
    /// Can not be transmitted.
    /// </summary>
    [Obsolete($"\"{nameof(Undefined)}\" can not be transmitted.")]
    Undefined = 0,

    /// <summary>
    /// Represents 32-bit single precision floating-point numerics. C# type: float or <see cref="Single"/>.
    /// </summary>
    /// <remarks>
    /// The largest representable integer is 24-bit.
    /// </remarks>
    Float = 1,

    /// <summary>
    /// Represents 64-bit double precision floating-point numerics. C# alias: double, C# type: <see cref="Double"/>.
    /// </summary>
    /// <remarks>
    /// For universal numeric data, as long as permitted by network and disk budget.
    /// The largest representable integer is 53-bit.
    /// </remarks>
    Double = 2,

    /// <summary>
    /// Represents variable length ASCII strings. C# type: string or <see cref="String"/>.
    /// </summary>
    /// <remarks>
    /// For data blobs such as video frames, complex event descriptions etc.
    /// </remarks>
    String = 3,

    /// <summary>
    /// Represents 32-bit integers. C# type: int or <see cref="Int32"/>.
    /// </summary>
    /// <remarks>
    /// For high rate digitized formats that require 32-bit precision.
    /// Depends critically on meta-data to represent meaningful units.
    /// Useful for application event codes or other coded data.
    /// </remarks>
    Int = 4,

    /// <summary>
    /// Represents 16-bit integers. C# type: short or <see cref="Int16"/>.
    /// </summary>
    /// <remarks>
    /// For very high-rate signals (40kHz+) or consumer grade audio.
    /// For professional audio float is recommended.
    /// </remarks>
    Short = 5,

    /// <summary>
    /// Represents 8-bit integers. C# type: sbyte or <see cref="SByte"/>.
    /// </summary>
    /// <remarks>
    /// For binary signals or other coded data.
    /// Not recommended for encoding string data.
    /// </remarks>
    SByte = 6,

    /// <summary>
    /// Represents 64-bit integers. C# type: long or <see cref="Int64"/>.
    /// </summary>
    /// <remarks>
    /// Is not supported / exposed for all languages. 
    /// </remarks>
    [Obsolete($"\"{nameof(Long)}\" is not supported by all languages.")]
    Long = 7
}