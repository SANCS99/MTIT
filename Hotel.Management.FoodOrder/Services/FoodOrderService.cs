

using Hotel.Management.FoodOrder.Data;
using Hotel.Management.FoodOrder.Models;

namespace Hotel.Management.FoodOrder.Services
{
    public class FoodOrderService : IFoodOrderService
    {
        public List<Models.FoodOrder> GetFoodOrders()
        {
            return FoodOrderMockDataService.FoodOrders;
        }

        public Models.FoodOrder? GetFoodOrder(int id)
        {
            return FoodOrderMockDataService.FoodOrders.FirstOrDefault(x => x.Id == id);
        }

        public Models.FoodOrder? AddFoodOrder(Models.FoodOrder foodorder)
        {
            FoodOrderMockDataService.FoodOrders.Add(foodorder);
            return foodorder;
        }

        public Models.FoodOrder? UpdateFoodOrder(Models.FoodOrder foodorder)
        {
            Models.FoodOrder selectedFoodOrder = FoodOrderMockDataService.FoodOrders.FirstOrDefault(x => x.Id == foodorder.Id);
            if (selectedFoodOrder != null)
            {
                selectedFoodOrder.Address = foodorder.Address;
                selectedFoodOrder.Price = foodorder.Price;
                selectedFoodOrder.Category = foodorder.Category;
                return selectedFoodOrder;
            }

            return selectedFoodOrder;
        }

        public bool? DeleteFoodOrder(int id)
        {
            Models.FoodOrder selectedFoodOrder = FoodOrderMockDataService.FoodOrders.FirstOrDefault(x => x.Id == id);
            if (selectedFoodOrder != null)
            {
                FoodOrderMockDataService.FoodOrders.Remove(selectedFoodOrder);
                return true;
            }
            return false;
        }
    }
}
