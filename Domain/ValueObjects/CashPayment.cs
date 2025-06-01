namespace Domain.ValueObjects;

public sealed class CashPayment : PaymentInstrument
{
    public CashPayment()
    {
        Id = Guid.NewGuid();
    }

    public override string Type => "CASH";
}
