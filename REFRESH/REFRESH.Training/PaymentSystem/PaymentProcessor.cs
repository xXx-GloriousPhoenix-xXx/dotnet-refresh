namespace REFRESH.Training.PaymentSystem;

public class PaymentProcessor
{
    private IPaymentMethod? _method;

    public void SetStrategy(IPaymentMethod method)
    {
        _method = method;
    }

    public void Execute(double amount)
    {
        if (_method is null)
        {
            throw new InvalidOperationException("Payment method is not selected");
        }
        
        _method.ProcessPayment(amount);
    }
}