namespace NewYearGift
{
    public interface ICurrencyConfig
    {
        CurrencyData[] CurrencyData { get; set; }
        CurrencyUnits? CurrentCurrency { get; set; }
    }
}