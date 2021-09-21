using System;

namespace NewYearGift
{
    public class GiftService : IGiftService
    {
        private static readonly GiftService _instance = new GiftService();
        private readonly GiftProvider _giftProvider;

        static GiftService()
        {
        }

        private GiftService()
        {
            _giftProvider = new GiftProvider();
            Init();
            GetFilteredSweetGift("Twix");
            GetSortedSweetGift("Price");
        }

        public static GiftService Instance => _instance;

        public Sweet[] SweetGift { get; private set; }

        public Sweet[] FilteredSweetGift { get; private set; }

        public Sweet[] SortedSweetGift { get; private set; }

        public double GiftTotalWeight { get; private set; }

        /*
        public Sweet[] GetGift()
        {
            return SweetGift;
        }
        */

        public Sweet[] GetFilteredSweetGift(string name)
        {
            FilteredSweetGift = new Sweet[SweetGift.Search(name).Length];
            FilteredSweetGift = SweetGift.Search(name);
            return FilteredSweetGift;
        }

        public Sweet[] GetFilteredSweetGift(double calories)
        {
            FilteredSweetGift = new Sweet[SweetGift.Search(calories).Length];
            FilteredSweetGift = SweetGift.Search(calories);
            return FilteredSweetGift;
        }

        public Sweet[] GetFilteredSweetGift(SweetTypes sweetType)
        {
            FilteredSweetGift = new Sweet[SweetGift.Search(sweetType).Length];
            FilteredSweetGift = SweetGift.Search(sweetType);
            return FilteredSweetGift;
        }

        public Sweet[] GetSortedSweetGift(string sort)
        {
            SortedSweetGift = new Sweet[SweetGift.Length];
            SweetGift.CopyTo(SortedSweetGift, 0);

            switch (sort)
            {
                case "Price":
                    SortedSweetGift.SortByPrice();
                    return SortedSweetGift;
                case "Weight":
                    SortedSweetGift.SortByWeight();
                    return SortedSweetGift;
                case "Calories":
                    SortedSweetGift.SortByCalories();
                    return SortedSweetGift;
                default:
                    throw new Exception("Error!");
            }
        }

        private void Init()
        {
            SweetGift = new Sweet[_giftProvider.SweetGift.Length];
            _giftProvider.SweetGift.CopyTo(SweetGift, 0);
            GiftTotalWeight = SweetGift.GetTotalWeight();
        }
    }
}
