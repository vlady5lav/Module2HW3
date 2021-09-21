namespace NewYearGift
{
    public class ClassicBarOfChocolate : BarOfChocolate
    {
        public ClassicBarOfChocolate()
        {
            BarOfChocolateType = BarOfChocolateTypes.Classic;
        }

        public ClassicBarOfChocolateTypes? ClassicBarOfChocolateType { get; set; }
    }
}
