public interface IShippingStrategy
{
    void CalculateFees(Order order);
}

public class ExpressShippingStrategy : IShippingStrategy
{
    public void CalculateFees(Order order)
    {
        //do business logic
    }
}

public class StandardShippingStrategy : IShippingStrategy
{
    public void CalculateFees(Order order)
    {
        //do business logic
    }
}