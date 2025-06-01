namespace Domain.ValueObjects;

public sealed class PixPayment : PaymentInstrument
{
    public PixPayment()
    {
        Id = Guid.NewGuid();
    }

    public override string Type => "PIX";
}