namespace LSL.Net.Options;

/// <summary>
/// Specifies the transport options for Lab Streaming Layer streams.
/// </summary>
public enum TransportOptions
{
    /// <summary>
    /// Default behaviour.
    /// Buffer size is interpreted as time in seconds amd asynchronous transfer is used.
    /// </summary>
    Default = 0,

    /// <summary>
    /// Buffer size is interpreted as samples rather than time.
    /// </summary>
    /// <remarks>
    /// Mutually exclusive with <see cref="BufferSizeThousandths"/>.
    /// </remarks>
    BufferSizeSamples = 1,

    /// <summary>
    /// Supplied buffer size should be scaled by 0.001.
    /// </summary>
    /// <remarks>
    /// Mutually exclusive with <see cref="BufferSizeSamples"/>.
    /// </remarks>
    BufferSizeThousandths = 2
}