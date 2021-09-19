namespace NewYearGift
{
    public abstract class FruitsBase : Sugar
    {
        public FruitsBase()
        {
            SugarType = SugarTypes.FruitsBase;
        }

        public virtual FruitsBaseTypes? FruitsBaseType { get; set; }
    }
}
