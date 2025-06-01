namespace Domain.ValueObjects;

public sealed class DebitCardPayment : PaymentInstrument
{
    public DebitCardPayment()
    {
        Id = Guid.NewGuid();
    }

    public override string Type => "DEBIT_CARD";
}
