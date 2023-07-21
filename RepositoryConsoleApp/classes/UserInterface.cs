using Classes;

public class ProgramUI
{
    public int Id { get; set; }
    public bool Running { get; set; }
    public DeliveryRepository DeliveryRepo { get; set; }
    public ProgramUI(DeliveryRepository deliveryRepo)
    {
        DeliveryRepo = deliveryRepo;
        Running = true;
        Id = 0;
    }
    public void Run()
    {
        Console.WriteLine("Option 1) Add a new delivery");
        Console.WriteLine("Option 2) List all en route deliveries");
        Console.WriteLine("Option 3) List all completed deliveries");
        Console.WriteLine("Option 4) Update the status of a delivery");
        Console.WriteLine("Option 5) Cancel a delivery");
        string option = Console.ReadLine();
        Console.Clear();
        switch (option)
        {
            case "1":
                CreateDelivery();
                break;
            case "2":
                ShowEnRouteDeliveries();
                break;
            case "3":
                ShowCompletedDeliveries();
                break;
            case "4":
                UpdateDelivery();
                break;
            case "5":
                CancelDelivery();
                break;
            default:
                Running = false;
                break;
        }
    }
    public void CreateDelivery()
    {
        Id += 1;
        Console.WriteLine("What is the item number?");
        int itemNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the quantity of items?");
        int quantity = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the customer id?");
        int customerId = int.Parse(Console.ReadLine());
        Delivery delivery = new Delivery(itemNumber, quantity, customerId, Id);
        DeliveryRepo.AddDeliveryToDirectory(delivery);
    }
    public void ShowEnRouteDeliveries()
    {
        List<Delivery> enRouteDeliveries = DeliveryRepo.GetEnRouteDeliveries();
        foreach (Delivery delivery in enRouteDeliveries)
        {
            Console.WriteLine($"Id: {delivery.DeliveryId}");
        }
        Console.ReadKey();
    }
    public void ShowCompletedDeliveries()
    {
        List<Delivery> completedDeliveries = DeliveryRepo.GetCompletedDeliveries();
        foreach (Delivery delivery in completedDeliveries)
        {
            Console.WriteLine($"Id: {delivery.DeliveryId}");
        }
        Console.ReadKey();
    }
    public void UpdateDelivery()
    {
        Console.WriteLine("What is the id of the delivery you would like to update?");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Please indicate which status to update the delivery to.");
        Console.WriteLine("1) Scheduled");
        Console.WriteLine("2) EnRoute");
        Console.WriteLine("3) Complete");
        string option = Console.ReadLine();
        Status status = new Status();
        switch (option)
        {
            case "1":
                status = Status.Scheduled;
                break;
            case "2":
                status = Status.EnRoute;
                break;
            case "3":
                status = Status.Complete;
                break;
            default:
                break;
        }
        DeliveryRepo.UpdateDeliveryStatus(id, status);
    }
    public void CancelDelivery()
    {
        Console.WriteLine("What is the id of the delivery you would like to cancel?");
        int id = int.Parse(Console.ReadLine());
        DeliveryRepo.CancelDelivery(id);
    }
}