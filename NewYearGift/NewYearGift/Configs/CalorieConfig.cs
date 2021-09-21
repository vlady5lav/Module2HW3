namespace NewYearGift
{
    public class CalorieConfig : ICalorieConfig
    {
        public CalorieData[] CalorieData { get; set; }

        public CalorieUnits? CurrentCalorie { get; set; }
    }
}
