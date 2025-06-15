public class OrderHandler
{
    private IShippingStrategy _strategy;

    public OrderHandler(IShippingStrategy strategy)
    {
        _strategy = strategy;
    }

    public void setStrategy(IShippingStrategy strategy)
    {
        _strategy = strategy;
    }


    public void handleOrder(Order order)
    {
        //do business logic 
        _strategy.CalculateFees(order);
    }
}
