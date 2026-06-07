namespace REFRESH.Training.PaymentSystem;

public class PayPalPayment : IPaymentMethod
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Paying with PayPal. Amount: {amount}");
    }
}
