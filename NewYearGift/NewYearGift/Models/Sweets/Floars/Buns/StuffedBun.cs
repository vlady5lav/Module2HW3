namespace NewYearGift
{
    public abstract class StuffedBun : Bun
    {
        public StuffedBun()
        {
            BunType = BunTypes.StuffedBun;
        }

        public StuffedBunTypes StuffedBunType { get; set; }
    }
}
