using System;

namespace NewYearGift
{
    public class SweetsProvider : ISweetsProvider
    {
        private readonly Random _random;

        public SweetsProvider()
        {
            _random = new Random();
            Init();
        }

        public Sweet[] AllSweets { get; private set; }

        /*
        public Sweet[] GetSweets()
        {
            return AllSweets;
        }
        */

        private void Init()
        {
            AllSweets = new Sweet[]
            {
                new Bounty(),
                new ChikaBar(),
                new Crunchy(),
                new Fitness(),
                new Lion(),
                new Mars(),
                new Nesquik(),
                new Nuts(),
                new Picnic(),
                new Snickers(),
                new Twix(),
                new WildRoar(),
            };

            foreach (Sweet sweet in AllSweets)
            {
                sweet.Price = _random.NextDoubleValue(20, 100);
                sweet.Calories = _random.Next(100, 1000);
                sweet.Weight = _random.NextDoubleValue(100);
                sweet.CurrencyUnit = (CurrencyUnits)_random.Next(3);
                sweet.CalorieUnit = (CalorieUnits)_random.Next(2);
                sweet.WeightUnit = (WeightUnits)_random.Next(3);
                sweet.IsForDiabetics = _random.NextBool();
            }
        }
    }
}
