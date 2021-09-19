using System;

namespace NewYearGift
{
    public class GiftProvider : IGiftProvider
    {
        private readonly SweetsService _sweetsService;
        private readonly Random _random;
        private readonly int _giftSize;

        public GiftProvider()
        {
            _sweetsService = new SweetsService();
            _random = new Random();
            _giftSize = ConfigService.Instance.Config.GiftConfig.GiftSize;
            Init();
        }

        public Sweet[] SweetGift { get; private set; }

        /*
        public Sweet[] GetGift()
        {
            return SweetGift;
        }
        */

        private void Init()
        {
            SweetGift = new Sweet[_giftSize];

            for (var i = 0; i < _giftSize; i++)
            {
                var randomIndex = _random.Next(0, _sweetsService.AllSweets.Length);
                var pickedSweet = _sweetsService.AllSweets[randomIndex];
                SweetGift[i] = pickedSweet;
            }
        }
    }
}
