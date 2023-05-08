namespace Hotel.Management.FoodOrder.Data
{
    public static class FoodOrderMockDataService
    {
        public static List<Models.FoodOrder> FoodOrders=new List<Models.FoodOrder>() 
        {
            new Models.FoodOrder {Id = 1, Category = "Fruts", Address = "Gampaha", Price = "200.00"},
            new Models.FoodOrder {Id = 2, Category = "Fruts", Address = "Malabe", Price = "300.00"},
            new Models.FoodOrder {Id = 3, Category = "Foods", Address = "Hatton", Price = "400.00"},
            new Models.FoodOrder {Id = 4, Category = "Butter", Address = "Gampaha", Price = "500.00"},
            new Models.FoodOrder {Id = 5, Category = "vegetables", Address = "Malabe", Price = "600.00"}
        };
    }
}
