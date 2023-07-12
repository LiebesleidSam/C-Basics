namespace Classes;

public class Indicator
{
    public bool IsFlashing { get; private set; }

    public void TurnOn()
    {
        if (!IsFlashing)
        {
            IsFlashing = true;
        }
    }
    public void TurnOff()
    {
        if (IsFlashing)
        {
            IsFlashing = false;
        }
    }
}