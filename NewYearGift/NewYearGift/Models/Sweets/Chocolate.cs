namespace NewYearGift
{
    public abstract class Chocolate : Sweet
    {
        public Chocolate()
        {
            SweetType = SweetTypes.Chocolate;
        }

        public virtual ChocolateTypes? ChocolateType { get; set; }
    }
}
