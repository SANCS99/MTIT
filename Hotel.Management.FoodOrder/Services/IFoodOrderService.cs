namespace Hotel.Management.FoodOrder.Services
{
    public interface IFoodOrderService
    {
        List<Models.FoodOrder> GetFoodOrders();
        Models.FoodOrder? GetFoodOrder(int id);
        Models.FoodOrder? AddFoodOrder(Models.FoodOrder foodorder);
        Models.FoodOrder? UpdateFoodOrder(Models.FoodOrder foodorder);
        bool? DeleteFoodOrder(int id);
    }
}
