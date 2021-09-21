namespace NewYearGift
{
    public abstract class Floar : Sweet
    {
        public Floar()
        {
            SweetType = SweetTypes.Floar;
        }

        public virtual FloarTypes? FloarType { get; set; }
    }
}
