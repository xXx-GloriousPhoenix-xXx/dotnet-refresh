namespace REFRESH.Training.PaymentSystem;

public class PaymentProcessor
{
    public static void Execute(IPaymentMethod method, double amount)
    {
        method.ProcessPayment(amount);
    }
}