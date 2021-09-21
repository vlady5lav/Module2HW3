namespace NewYearGift
{
    public abstract class ButterBun : Bun
    {
        public ButterBun()
        {
            BunType = BunTypes.ButterBun;
        }

        public ButterBunTypes ButterBunType { get; set; }
    }
}
