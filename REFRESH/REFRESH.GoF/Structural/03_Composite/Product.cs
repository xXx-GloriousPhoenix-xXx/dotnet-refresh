namespace REFRESH.GoF.Structural._03_Composite;
public class Product(string name, decimal price) : INode
{
    public string Name { get; init; } = name;
    public decimal Price { get; set; } = price;
    public decimal Total() => Price;
}
