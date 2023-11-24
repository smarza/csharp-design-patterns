namespace DesignPatterns.Structural.ChainOfResponsibility.ConversionTask;

public enum ConversionJobStatus
{
    Idle = 0,

    Enqueued = 1,

    WaitingForResource = 2,

    Converting = 3,

    Converted = 4,

    Cancelled = 5,

    Error = 6,
}