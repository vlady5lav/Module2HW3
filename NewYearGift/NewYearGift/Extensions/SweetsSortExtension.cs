using System;
using System.Collections;

namespace NewYearGift
{
    public static class SweetsSortExtension
    {
        private static readonly CaloriesComparer _caloriesComparer;
        private static readonly PriceComparer _priceComparer;
        private static readonly WeightComparer _weightComparer;

        static SweetsSortExtension()
        {
            _caloriesComparer = new CaloriesComparer();
            _priceComparer = new PriceComparer();
            _weightComparer = new WeightComparer();
        }

        public static void SortByCalories(this Sweet[] sweets)
        {
            Array.Sort(sweets, _caloriesComparer);
        }

        public static void SortByPrice(this Sweet[] sweets)
        {
            Array.Sort(sweets, _priceComparer);
        }

        public static void SortByWeight(this Sweet[] sweets)
        {
            Array.Sort(sweets, _weightComparer);
        }

        public static void SortByChoose(this Sweet[] sweets, IComparer comparer)
        {
            Array.Sort(sweets, comparer);
        }
    }
}
