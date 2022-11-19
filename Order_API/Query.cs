namespace Order_API
{   
    public class Query 
    {
        [UsePaging]
        [UseFiltering(typeof(CustomOrderFilterType))]
        [UseSorting(typeof(CustomOrderSortType))]
        public List<OrderType> GetOrder([Service] OrderRepository orderRepository)
        {
            return orderRepository.GetOrder();
        }

        [UsePaging]
        [UseFiltering(typeof(CustomOrderFilterType))]
        [UseSorting(typeof(CustomOrderSortType))]
        public List<OrderType> GetOrderBy([Service] OrderRepository orderRepository,string name)
        {
            return orderRepository.GetOrderBy(name);
        }
    }
}
