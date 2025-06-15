//program
var orders = new List<Order>();
var result =  new List<Order>();


OrderHandler handler = new OrderHandler(new ExpressShippingStrategy());
var expressOrders = orders.Where(o => o.IsExpressShipping);

foreach (var order in expressOrders)
{
    handler.handleOrder(order);
}


handler.setStrategy(new StandardShippingStrategy());
foreach (var order in orders.Except(expressOrders))
{
    handler.handleOrder(order);
}
Console.ReadKey();