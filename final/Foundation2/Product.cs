public class Product
{
    private int _productId;
    private string _name;
    private double _price;
    private int _quantity;

    public Product(int productId, string name, double price, int quantity)
    {
        _productId = productId;
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public int TotalCost()
    {
        return 0;
    }
}