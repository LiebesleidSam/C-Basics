namespace Classes;

public enum VehicleType { Car, Truck, Van, Motorcylce, Boat, Plain, Spaceship }


public class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public double Mileage { get; set; }
    public string Color { get; set; }
    public VehicleType TypeOfVehicle { get; set; }
    public bool IsRunning { get; private set; }
    public Indicator RightIndicator { get; } = new Indicator();
    public Indicator LeftIndicator { get; } = new Indicator();

    public void TurnOn()
    {
        if (!IsRunning)
        {
            IsRunning = true;
        }
    }
    public void TurnOff()
    {
        if (IsRunning)
        {
            IsRunning = false;
        }
    }
    public void IndicateRight()
    {
        if (IsRunning && !RightIndicator.IsFlashing)
        {
            RightIndicator.TurnOn();
            LeftIndicator.TurnOff();
        }
    }
    public void IndicateLeft()
    {
        if (IsRunning && !LeftIndicator.IsFlashing)
        {
            LeftIndicator.TurnOn();
            RightIndicator.TurnOff();
        }
    }
    public void TurnOnHazards()
    {
        RightIndicator.TurnOn();
        LeftIndicator.TurnOn();
    }
    public void ClearIndicators()
    {
        RightIndicator.TurnOff();
        LeftIndicator.TurnOff();
    }
}