namespace Domain.ValueObjects;
public abstract class PaymentInstrument
{
    public Guid Id { get; protected set; }
    public abstract string Type { get; }
}
