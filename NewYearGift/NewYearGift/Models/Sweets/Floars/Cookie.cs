namespace NewYearGift
{
    public abstract class Cookie : Floar
    {
        public Cookie()
        {
            FloarType = FloarTypes.Cookie;
        }

        public virtual CookieTypes? CookieType { get; set; }
    }
}
