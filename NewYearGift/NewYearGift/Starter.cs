using System;

namespace NewYearGift
{
    public class Starter
    {
        private readonly GiftService _giftService;

        public Starter()
        {
            _giftService = GiftService.Instance;
        }

        public void Run()
        {
            Console.WriteLine($"{Environment.NewLine}New Year Gift (Total Weight: {Math.Round((decimal)_giftService.GiftTotalWeight, 2)} {WeightUnits.KG}):");

            foreach (var sweet in _giftService.SweetGift)
            {
                Console.WriteLine($"{sweet.Name} - {Math.Round((decimal)sweet.Price, 2)} {sweet.CurrencyUnit} - {Math.Round((decimal)sweet.Calories, 2)} {sweet.CalorieUnit} - {Math.Round((decimal)sweet.Weight, 2)} {sweet.WeightUnit}");
            }

            Console.WriteLine($"{Environment.NewLine}Filtered by name \"Twix\" ({_giftService.FilteredSweetGift.Length} pcs):");

            foreach (var sweet in _giftService.FilteredSweetGift)
            {
                Console.WriteLine($"{sweet.Name} - {Math.Round((decimal)sweet.Price, 2)} {sweet.CurrencyUnit} - {Math.Round((decimal)sweet.Calories, 2)} {sweet.CalorieUnit} - {Math.Round((decimal)sweet.Weight, 2)} {sweet.WeightUnit}");
            }

            Console.WriteLine($"{Environment.NewLine}Sorted by Price:");

            foreach (var sweet in _giftService.SortedSweetGift)
            {
                Console.WriteLine($"{sweet.Name} - {Math.Round((decimal)sweet.Price, 2)} {sweet.CurrencyUnit} - {Math.Round((decimal)sweet.Calories, 2)} {sweet.CalorieUnit} - {Math.Round((decimal)sweet.Weight, 2)} {sweet.WeightUnit}");
            }
        }
    }
}
