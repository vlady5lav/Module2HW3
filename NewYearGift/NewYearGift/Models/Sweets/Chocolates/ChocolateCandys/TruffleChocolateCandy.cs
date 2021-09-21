namespace NewYearGift
{
    public class TruffleChocolateCandy : ChocolateCandy
    {
        public TruffleChocolateCandy()
        {
            ChocolateCandyType = ChocolateCandyTypes.Truffle;
        }

        public TruffleChocolateCandyTypes? TruffleChocolateCandyType { get; set; }
    }
}
