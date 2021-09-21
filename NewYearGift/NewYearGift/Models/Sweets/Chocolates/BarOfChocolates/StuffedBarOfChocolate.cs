namespace NewYearGift
{
    public class StuffedBarOfChocolate : BarOfChocolate
    {
        public StuffedBarOfChocolate()
        {
            BarOfChocolateType = BarOfChocolateTypes.Stuffed;
        }

        public StuffedBarOfChocolateTypes? StuffedBarOfChocolateType { get; set; }
    }
}
