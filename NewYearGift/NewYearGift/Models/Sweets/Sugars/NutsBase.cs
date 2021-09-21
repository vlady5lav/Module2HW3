namespace NewYearGift
{
    public abstract class NutsBase : Sugar
    {
        public NutsBase()
        {
            SugarType = SugarTypes.NutsBase;
        }

        public virtual NutsBaseTypes? NutsBaseType { get; set; }
    }
}
