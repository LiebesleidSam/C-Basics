using Classes;

public class DeliveryRepository
{
    private readonly List<Delivery> _deliveryDirectory = new List<Delivery>();

    public bool AddDeliveryToDirectory(Delivery delivery)
    {
        int startingCount = _deliveryDirectory.Count();

        if (delivery != null)
        {
            _deliveryDirectory.Add(delivery);
        }

        bool countIncreased = _deliveryDirectory.Count() > startingCount;
        return countIncreased;
    }
    public List<Delivery> GetDirectory()
    {
        return new List<Delivery>(_deliveryDirectory);
    }
    public Delivery? GetDeliveryByDeliveryId(int id)
    {
        foreach (Delivery delivery in _deliveryDirectory)
        {
            if (delivery.DeliveryId == id)
            {
                return delivery;
            }
        }
        return null;
    }
    public List<Delivery> GetEnRouteDeliveries()
    {
        List<Delivery> enRouteDeliveries = new List<Delivery>();
        foreach (Delivery delivery in _deliveryDirectory)
        {
            if (delivery.Status == Status.EnRoute)
            {
                enRouteDeliveries.Add(delivery);
            }
        }
        return enRouteDeliveries;
    }
    public List<Delivery> GetCompletedDeliveries()
    {
        List<Delivery> completedDeliveries = new List<Delivery>();
        foreach (Delivery delivery in _deliveryDirectory)
        {
            if (delivery.Status == Status.Complete)
            {
                completedDeliveries.Add(delivery);
            }
        }
        return completedDeliveries;
    }
    public bool UpdateDeliveryStatus(int id, Status newStatus)
    {
        Delivery? oldDelivery = GetDeliveryByDeliveryId(id);
        if (oldDelivery == null)
        {
            return false;
        }

        oldDelivery.Status = newStatus;
        return true;
    }
    public bool CancelDelivery(int id)
    {
        Delivery? targetDelivery = GetDeliveryByDeliveryId(id);
        if (targetDelivery == null)
        {
            return false;
        }

        targetDelivery.Status = Status.Canceled;
        return true;
    }
}