using System;

abstract class Payment
{
    public decimal Amount { get; }

    protected Payment(decimal amount)
    {
        Amount = amount;
    }

    public abstract bool Process();
}

interface IRefundable
{
    bool Refund();
}

class CardPayment: Payment, IRefundable
{
    public CardPayment(decimal amount) : base(amount) { }

    public override bool Process()
    {
        return Amount > 0;
    }

    public bool Refund()
    {
        return true;
    }
}

class PointPayment : Payment
{
    public PointPayment(decimal amount) : base(amount) { }

    public override bool Process()
    {
        return Amount > 0;
    }
}

class PaymentProcessor
{
    public Action<string>? OnResult;

    public bool Pay(Payment payment)
    {
        bool success = payment.Process();

        OnResult?.Invoke(success 
            ? $"Payment succeeded: {payment.GetType().Name}, Amount={payment.Amount}"
            : $"Payment failed: {payment.GetType().Name}, Amount={payment.Amount}"
        );
        
        return success;
    }

    public bool TryRefund(Payment payment)
    {
        if (payment is not IRefundable refundable)
        {
            OnResult?.Invoke($"Refunc not supported: {payment.GetType().Name}");
            return false;
        }

        bool success = refundable.Refund();
        OnResult?.Invoke(success ? "Refund successed" : "Refund failed");
        return success;
    }
}

class Program
{
    static void Main()
    {
        var processor = new PaymentProcessor();
        processor.OnResult += Console.WriteLine;

        Payment card = new CardPayment(100m);
        processor.Pay(card);
        processor.TryRefund(card);
    }
}