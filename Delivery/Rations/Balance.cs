﻿using Delivery.Foods;

namespace Delivery.Rations
{
    /// <summary>
    /// Сбалансированный рацион
    /// </summary>
    public class Balance : IRation
    {
        /// <summary>
        /// Тип рациона
        /// </summary>
        public RationType Type { get; }
        /// <summary>
        /// Список продуктов
        /// </summary>
        public List<IFood>? FoodList { get; set; }
        /// <summary>
        /// Калории
        /// </summary>
        public float Calories { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }

        public Balance()
        {
            Type = RationType.Balance;
            FoodList = new List<IFood>();
        }
        public override string ToString()
        {
            string type = "Type: " + Type;
            string foodlist = FoodList!.ToArray().ToString()!;
            string price = string.Format("\nPrice: {00:0.00}р", Price);
            string calories = string.Format("\nCalories: {00:0.00} калл", Calories);

            return type + foodlist + price + calories;
        }
    }
}
