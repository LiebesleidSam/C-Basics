namespace Classes;

public enum Status {Scheduled, EnRoute, Complete, Canceled}
public class Delivery
{
    public Delivery(int itemNumber, int quantity, int customerId, int deliveryId)
    {
        OrderDate = DateTime.Today;
        DeliveryDate = new DateTime();
        Status = Status.Scheduled;
        ItemNumber = itemNumber;
        Quantity = quantity;
        CustomerId = customerId;
        DeliveryId = deliveryId;
    }
    public DateTime OrderDate { get; set; }
    public DateTime DeliveryDate { get; set; }
    public Status Status { get; set; }
    public int ItemNumber { get; set; }
    public int Quantity { get; set; }
    public int CustomerId { get; set; }
    public int DeliveryId { get; set; }
}