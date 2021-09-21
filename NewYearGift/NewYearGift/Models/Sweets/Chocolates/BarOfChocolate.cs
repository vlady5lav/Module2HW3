namespace NewYearGift
{
    public abstract class BarOfChocolate : Chocolate
    {
        public BarOfChocolate()
        {
            ChocolateType = ChocolateTypes.BarOfChocolate;
        }

        public virtual BarOfChocolateTypes? BarOfChocolateType { get; set; }
    }
}
