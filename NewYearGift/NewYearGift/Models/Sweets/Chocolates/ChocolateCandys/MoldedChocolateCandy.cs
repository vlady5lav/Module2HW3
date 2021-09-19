namespace NewYearGift
{
    public class MoldedChocolateCandy : ChocolateCandy
    {
        public MoldedChocolateCandy()
        {
            ChocolateCandyType = ChocolateCandyTypes.Molded;
        }

        public MoldedChocolateCandyTypes? MoldedChocolateCandyType { get; set; }
    }
}
