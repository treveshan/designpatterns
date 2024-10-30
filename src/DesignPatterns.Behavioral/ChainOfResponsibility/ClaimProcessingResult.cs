namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public class ClaimProcessingResult
{
    public bool IsProcessed { get; }
    public string Message { get; }

    public ClaimProcessingResult(bool isProcessed, string message)
    {
        IsProcessed = isProcessed;
        Message = message;
    }

    public override string ToString() => Message;
}