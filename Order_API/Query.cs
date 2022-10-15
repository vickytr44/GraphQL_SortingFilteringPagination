namespace Order_API
{   
    public class Query 
    {
        [UseSorting(typeof(CustomerOrderSortType))]
        public List<OrderType> GetOrder([Service] OrderRepository orderRepository)
        {
            return orderRepository.GetOrder();
        }

        [UseSorting(typeof(CustomerOrderSortType))]
        public List<OrderType> GetOrderBy([Service] OrderRepository orderRepository,string name)
        {
            return orderRepository.GetOrderBy(name);
        }
    }
}
