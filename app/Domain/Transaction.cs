namespace app.Domain
{
    public class Transaction
    {
        public int Id { get; set; }
        public Person Seller { get; set; }
        public List<Order> Orders { get; set; }
        public decimal Total { get; set; }
    }
}
