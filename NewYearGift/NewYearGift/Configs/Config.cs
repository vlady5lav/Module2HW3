namespace NewYearGift
{
    public class Config : IConfig
    {
        public CalorieConfig CalorieConfig { get; set; }

        public CurrencyConfig CurrencyConfig { get; set; }

        public GiftConfig GiftConfig { get; set; }

        public WeightConfig WeightConfig { get; set; }
    }
}
