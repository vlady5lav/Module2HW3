namespace NewYearGift
{
    public abstract class YeastFreeBun : Bun
    {
        public YeastFreeBun()
        {
            BunType = BunTypes.YeastFreeBun;
        }

        public YeastFreeBunTypes YeastFreeBunType { get; set; }
    }
}
