namespace NewYearGift
{
    public class SweetsService : ISweetsService
    {
        private readonly SweetsProvider _sweetsProvider;

        private readonly Config _config;
        private readonly CurrencyData[] _currencyData;
        private readonly CalorieData[] _calorieData;
        private readonly WeightData[] _weightData;

        public SweetsService()
        {
            _sweetsProvider = new SweetsProvider();

            _config = ConfigService.Instance.Config;
            _currencyData = _config.CurrencyConfig.CurrencyData;
            _calorieData = _config.CalorieConfig.CalorieData;
            _weightData = _config.WeightConfig.WeightData;

            Init();
        }

        public Sweet[] AllSweets { get; private set; }

        private void ConvertCurrency(Sweet[] sweets)
        {
            foreach (var sweet in sweets)
            {
                var currencyData = GetCurrencyData(sweet.CurrencyUnit.Value);
                sweet.Price *= currencyData.DefaultToCurrentRate;
                sweet.CurrencyUnit = _config.CurrencyConfig.CurrentCurrency;
            }
        }

        private CurrencyData GetCurrencyData(CurrencyUnits currencyUnit)
        {
            foreach (var currencyData in _currencyData)
            {
                if (currencyData.CurrencyUnit == currencyUnit)
                {
                    return currencyData;
                }
            }

            return null;
        }

        private void ConvertCalories(Sweet[] sweets)
        {
            foreach (var sweet in sweets)
            {
                var calorieData = GetCalorieData(sweet.CalorieUnit.Value);
                sweet.Calories *= calorieData.DefaultToCurrentRate;
                sweet.CalorieUnit = _config.CalorieConfig.CurrentCalorie;
            }
        }

        private CalorieData GetCalorieData(CalorieUnits calorieUnit)
        {
            foreach (var calorieData in _calorieData)
            {
                if (calorieData.CalorieUnit == calorieUnit)
                {
                    return calorieData;
                }
            }

            return null;
        }

        private void ConvertWeight(Sweet[] sweets)
        {
            foreach (var sweet in sweets)
            {
                var weightData = GetWeightData(sweet.WeightUnit.Value);
                sweet.Weight *= weightData.DefaultToCurrentRate;
                sweet.WeightUnit = _config.WeightConfig.CurrentWeight;
            }
        }

        private WeightData GetWeightData(WeightUnits weightUnit)
        {
            foreach (var weightData in _weightData)
            {
                if (weightData.WeightUnit == weightUnit)
                {
                    return weightData;
                }
            }

            return null;
        }

        private void Init()
        {
            AllSweets = new Sweet[_sweetsProvider.AllSweets.Length];
            _sweetsProvider.AllSweets.CopyTo(AllSweets, 0);
            ConvertCurrency(AllSweets);
            ConvertCalories(AllSweets);
            ConvertWeight(AllSweets);
        }
    }
}
