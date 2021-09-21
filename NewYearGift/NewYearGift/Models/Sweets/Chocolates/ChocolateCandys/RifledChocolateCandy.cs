namespace NewYearGift
{
    public class RifledChocolateCandy : ChocolateCandy
    {
        public RifledChocolateCandy()
        {
            ChocolateCandyType = ChocolateCandyTypes.Rifled;
        }

        public RifledChocolateCandyTypes? RifledChocolateCandyType { get; set; }
    }
}
