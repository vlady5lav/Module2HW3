namespace NewYearGift
{
    public interface IConfigService
    {
        CalorieConfig CalorieConfig { get; }
        Config Config { get; }
        CurrencyConfig CurrencyConfig { get; }
        GiftConfig GiftConfig { get; }
        WeightConfig WeightConfig { get; }
    }
}