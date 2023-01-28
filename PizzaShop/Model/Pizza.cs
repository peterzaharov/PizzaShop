﻿using System.Collections.Generic;

namespace PizzaShop
{
    public class Pizza
    {
        public const int MinimumSize = 9;
        public const int MaximumSize = 17;

        public int Id { get; set; }
        public int OrderId { get; set; }
        public PizzaSpecial Special { get; set; }
        public int SpecialId { get; set; }
        public int Size { get; set; }
        public List<PizzaTopping> Toppings { get; set; }
        public int DefaultSize { get; set; } = 12;

        public decimal GetBasePrice()
        {
            return ((decimal)Size / (decimal)DefaultSize) * Special.BasePrice;
        }

        public decimal GetTotalPrice()
        {
            return GetBasePrice(); 
        }

        public string GetFormattedTotalPrice()
        {
            return GetTotalPrice().ToString("0.00");
        }
    }
}