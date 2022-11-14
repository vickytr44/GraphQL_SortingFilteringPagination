namespace Order_API
{   
    public class Query 
    {
        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public List<OrderType> GetOrder([Service] OrderRepository orderRepository)
        {
            return orderRepository.GetOrder();
        }

        [UsePaging]
        [UseFiltering]
        [UseSorting]
        public List<OrderType> GetOrderBy([Service] OrderRepository orderRepository,string name)
        {
            return orderRepository.GetOrderBy(name);
        }
    }
}
