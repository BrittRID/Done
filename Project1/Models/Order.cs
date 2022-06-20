namespace Project1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ItemNumber { get; set; } = String.Empty;      
        
        public float Total { get; set; }
        public bool IsSale { get; set; }
        public Order()
        {

        }
    }
}
