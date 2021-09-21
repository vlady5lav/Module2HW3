namespace NewYearGift
{
    public abstract class SugarBase : Sugar
    {
        public SugarBase()
        {
            SugarType = SugarTypes.SugarBase;
        }

        public virtual SugarBaseTypes? SugarBaseType { get; set; }
    }
}
