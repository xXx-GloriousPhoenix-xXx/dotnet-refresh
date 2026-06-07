namespace REFRESH.Training.PaymentSystem;

public class CreditCardPayment : IPaymentMethod
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Paying with credit card. Amount: {amount}");
    }
}
