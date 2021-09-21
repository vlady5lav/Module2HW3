namespace NewYearGift
{
    public abstract class Sweet
    {
        public string Name { get; init; }

        public virtual double Price { get; set; }

        public virtual CurrencyUnits? CurrencyUnit { get; set; } = CurrencyUnits.UAH;

        public virtual double Calories { get; set; }

        public virtual CalorieUnits? CalorieUnit { get; set; } = CalorieUnits.KCAL;

        public virtual double Weight { get; set; }

        public virtual WeightUnits? WeightUnit { get; set; } = WeightUnits.G;

        public virtual SweetTypes? SweetType { get; init; }

        public virtual bool? IsForDiabetics { get; set; } = false;
    }
}
