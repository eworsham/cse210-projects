public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {

    }

    public int TotalCost()
    {
        return 0;
    }

    public string ToStringPackingLabel()
    {
        return "";
    }

    public string ToStringShippingLabel()
    {
        return "";
    }
}