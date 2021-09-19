namespace NewYearGift
{
    public abstract class Sugar : Sweet
    {
        public Sugar()
        {
            SweetType = SweetTypes.Sugar;
        }

        public virtual SugarTypes? SugarType { get; set; }
    }
}
