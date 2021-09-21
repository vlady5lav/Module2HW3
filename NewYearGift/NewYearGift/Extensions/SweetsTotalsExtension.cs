namespace NewYearGift
{
    public static class SweetsTotalsExtension
    {
        public static double GetTotalWeight(this Sweet[] sweets)
        {
            double totalWeight = 0;

            foreach (Sweet sweet in sweets)
            {
                totalWeight += sweet.Weight;
            }

            return totalWeight;
        }

        public static double GetTotalPrice(this Sweet[] sweets)
        {
            double totalPrice = 0;

            foreach (Sweet sweet in sweets)
            {
                totalPrice += sweet.Price;
            }

            return totalPrice;
        }

        public static double GetTotalCalories(this Sweet[] sweets)
        {
            double totalCalories = 0;

            foreach (Sweet sweet in sweets)
            {
                totalCalories += sweet.Calories;
            }

            return totalCalories;
        }
    }
}
