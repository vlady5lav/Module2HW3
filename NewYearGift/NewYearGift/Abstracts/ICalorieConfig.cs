namespace NewYearGift
{
    public interface ICalorieConfig
    {
        CalorieData[] CalorieData { get; set; }
        CalorieUnits? CurrentCalorie { get; set; }
    }
}