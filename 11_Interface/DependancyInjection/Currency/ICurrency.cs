namespace Currency;

public interface ICurrency
{
    string Name { get; }
    decimal Value { get; }
}