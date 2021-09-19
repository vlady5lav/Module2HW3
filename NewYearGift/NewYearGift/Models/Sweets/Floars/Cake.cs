namespace NewYearGift
{
    public abstract class Cake : Floar
    {
        public Cake()
        {
            FloarType = FloarTypes.Cake;
        }

        public virtual CakeTypes? CakeType { get; set; }
    }
}
