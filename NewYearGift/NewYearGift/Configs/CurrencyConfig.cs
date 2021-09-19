namespace NewYearGift
{
    public class CurrencyConfig : ICurrencyConfig
    {
        public CurrencyData[] CurrencyData { get; set; }

        public CurrencyUnits? CurrentCurrency { get; set; }
    }
}
