namespace NewYearGift
{
    public abstract class ChocolateCandy : Chocolate
    {
        public ChocolateCandy()
        {
            ChocolateType = ChocolateTypes.ChocolateCandy;
        }

        public virtual ChocolateCandyTypes? ChocolateCandyType { get; set; }
    }
}
