namespace Domain.ValueObjects;

public sealed class BankTransferPayment : PaymentInstrument
{
    public BankTransferPayment()
    {
        Id = Guid.NewGuid();
    }

    public override string Type => "BANK_TRANSFER";
}
