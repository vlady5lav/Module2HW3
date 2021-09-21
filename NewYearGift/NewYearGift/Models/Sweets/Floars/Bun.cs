namespace NewYearGift
{
    public abstract class Bun : Floar
    {
        public Bun()
        {
            FloarType = FloarTypes.Bun;
        }

        public virtual BunTypes? BunType { get; set; }
    }
}
