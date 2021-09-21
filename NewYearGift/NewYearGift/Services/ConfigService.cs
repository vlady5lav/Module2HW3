namespace NewYearGift
{
    public class ConfigService : IConfigService
    {
        private static readonly ConfigService _instance = new ConfigService();

        static ConfigService()
        {
        }

        private ConfigService()
        {
            Init();
            CalorieConfig = Config.CalorieConfig;
            CurrencyConfig = Config.CurrencyConfig;
            GiftConfig = Config.GiftConfig;
            WeightConfig = Config.WeightConfig;
        }

        public static ConfigService Instance => _instance;
        public Config Config { get; private set; }
        public CalorieConfig CalorieConfig { get; private set; }
        public CurrencyConfig CurrencyConfig { get; private set; }
        public GiftConfig GiftConfig { get; private set; }
        public WeightConfig WeightConfig { get; private set; }

        private void Init()
        {
            Config = new Config()
            {
                CalorieConfig = new CalorieConfig()
                {
                    CalorieData = new CalorieData[]
                    {
                        new CalorieData
                        {
                            CalorieUnit = CalorieUnits.KCAL,
                            DefaultToCurrentRate = 1
                        },
                        new CalorieData
                        {
                            CalorieUnit = CalorieUnits.KJ,
                            DefaultToCurrentRate = 4.184
                        }
                    },

                    CurrentCalorie = CalorieUnits.KCAL
                },

                CurrencyConfig = new CurrencyConfig()
                {
                    CurrencyData = new CurrencyData[]
                    {
                        new CurrencyData
                        {
                            CurrencyUnit = CurrencyUnits.UAH,
                            DefaultToCurrentRate = 1
                        },
                        new CurrencyData
                        {
                            CurrencyUnit = CurrencyUnits.USD,
                            DefaultToCurrentRate = 27.0
                        },
                        new CurrencyData
                        {
                            CurrencyUnit = CurrencyUnits.EUR,
                            DefaultToCurrentRate = 31.0
                        },
                    },

                    CurrentCurrency = CurrencyUnits.UAH
                },

                GiftConfig = new GiftConfig()
                {
                    GiftSize = 50,
                },

                WeightConfig = new WeightConfig()
                {
                    WeightData = new WeightData[]
                    {
                        new WeightData
                        {
                            WeightUnit = WeightUnits.KG,
                            DefaultToCurrentRate = 1
                        },
                        new WeightData
                        {
                            WeightUnit = WeightUnits.G,
                            DefaultToCurrentRate = 0.001
                        },
                        new WeightData
                        {
                            WeightUnit = WeightUnits.LB,
                            DefaultToCurrentRate = 0.4536
                        },
                    },

                    CurrentWeight = WeightUnits.KG
                }
            };
        }
    }
}
