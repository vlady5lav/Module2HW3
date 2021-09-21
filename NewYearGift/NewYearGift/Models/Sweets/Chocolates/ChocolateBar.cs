namespace NewYearGift
{
    public abstract class ChocolateBar : Chocolate
    {
        public ChocolateBar()
        {
            ChocolateType = ChocolateTypes.ChocolateBar;
        }

        public virtual ChocolateBarTypes? ChocolateBarType { get; set; }
    }
}
