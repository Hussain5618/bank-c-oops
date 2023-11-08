public class Customer
{
    public Guid CustomerId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }

    public Customer(string name, string address)
    {
        CustomerId = Guid.NewGuid();
        Name = name;
        Address = address;
    }
}