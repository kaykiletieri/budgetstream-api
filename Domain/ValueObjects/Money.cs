namespace Domain.ValueObjects;
public sealed class Money
{
    public decimal Amount { get; }
    public string Currency { get; }

    public Money(decimal amount, string currency = "BRL")
    {
        if (amount < 0) throw new ArgumentException("Amount must be non-negative", nameof(amount));
        if (string.IsNullOrWhiteSpace(currency)) throw new ArgumentException("Currency required", nameof(currency));
        Amount = amount;
        Currency = currency;
    }

    public Money Add(Money other)
    {
        EnsureSameCurrency(other);
        return new Money(Amount + other.Amount, Currency);
    }

    public Money Subtract(Money other)
    {
        EnsureSameCurrency(other);
        decimal result = Amount - other.Amount;
        if (result < 0) throw new InvalidOperationException("Resulting amount cannot be negative");
        return new Money(result, Currency);
    }

    public int CompareTo(Money other)
    {
        EnsureSameCurrency(other);
        return Amount.CompareTo(other.Amount);
    }

    private void EnsureSameCurrency(Money other)
    {
        if (Currency != other.Currency)
            throw new InvalidOperationException("Cannot operate on different currencies");
    }

    public override bool Equals(object? obj)
    {
        if (obj is Money m)
            return Amount == m.Amount && Currency == m.Currency;
        return false;
    }

    public override int GetHashCode() => HashCode.Combine(Amount, Currency);

    public override string ToString() => $"{Amount} {Currency}";
}
