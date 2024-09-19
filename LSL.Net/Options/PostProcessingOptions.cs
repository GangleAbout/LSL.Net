namespace LSL.Net.Options;

/// <summary>
/// Post-processing options for Lab Streaming Layer inlets.  
/// </summary>
/// <remarks>
/// Multiple post-processing options can be added to an inlet using <see href="https://en.wikipedia.org/wiki/Bitwise_operation#OR">bitwise OR</see>.
/// <code>
/// var option = PostProcessingOptions.DeJitter | PostProcessingOptions.Monotonize
/// </code> 
/// </remarks>
public enum PostProcessingOptions
{
    /// <summary>
    /// No automatic post-processing.
    /// </summary>
    /// <remarks>
    /// Default behaviour.
    /// </remarks>
    None = 0,

    /// <summary>
    /// Automatic clock synchronization.
    /// </summary>
    /// <remarks>
    /// Equivalent to manually adding value returned by time_correction() to the received timestamps.  
    /// </remarks>
    ClockSync = 1,

    /// <summary>
    /// Remove jitter from timestamps.
    /// </summary>
    /// <remarks>
    /// Applies a smoothing algorithm to the received timestamps, the algorithm needs a minimum number of samples (30-120 seconds worst case)
    /// until the remaining jitter is consistently below 1ms.
    /// </remarks>
    DeJitter = 2,

    /// <summary>
    /// Timestamps are monotonically ascending.
    /// </summary>
    /// <remarks>
    /// Only makes sense if timestamps are de-jittered.
    /// </remarks>
    Monotonize = 4,

    /// <summary>
    /// Post-processing is thread safe.
    /// Same inlet can be read from, by multiple threads.
    /// </summary>
    /// <remarks>
    /// Uses 'somewhat' more CPU.
    /// </remarks>
    ThreadSafe = 8,

    /// <summary>
    /// Combination of all possible post-processing options.
    /// </summary>
    All = ClockSync | DeJitter | Monotonize | ThreadSafe
}