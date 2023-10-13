namespace DesignPatterns.Structural.ChainOfResponsibility;

public class Request
{
    public bool IsUserActive { get; set; }
    public double UserBalance { get; set; }
    public double ProductPrice { get; set; }
    public int ProductStock { get; set; }
}
