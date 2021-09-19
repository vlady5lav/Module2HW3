namespace NewYearGift
{
    public interface IConfig
    {
        CalorieConfig CalorieConfig { get; set; }
        CurrencyConfig CurrencyConfig { get; set; }
        GiftConfig GiftConfig { get; set; }
        WeightConfig WeightConfig { get; set; }
    }
}