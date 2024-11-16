namespace _18_11_hw1;

public class Product
{
    public string Name { get; set; }
    public int Amount {  get; set; }
    public string MeasureUnit { get; set; }

    public Product(string name, int amount)
    {
        Name = name;
        Amount = amount;
    }
    public Product() { }
}
