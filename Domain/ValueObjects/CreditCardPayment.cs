namespace Domain.ValueObjects;

public sealed class CreditCardPayment : PaymentInstrument
{
    public Guid CreditCardId { get; }
    public CreditCardPayment(Guid creditCardId)
    {
        if (creditCardId == Guid.Empty) throw new ArgumentException("CreditCardId required", nameof(creditCardId));
        CreditCardId = creditCardId;
        Id = Guid.NewGuid();
    }

    public override string Type => "CREDIT_CARD";
}
