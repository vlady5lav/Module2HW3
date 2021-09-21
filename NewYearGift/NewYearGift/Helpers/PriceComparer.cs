using System.Collections;

namespace NewYearGift
{
    public class PriceComparer : IComparer, IPriceComparer
    {
        public int Compare(object x, object y)
        {
            var sweet1 = x as Sweet;
            var sweet2 = y as Sweet;

            if (sweet1.Price > sweet2.Price)
            {
                return 1;
            }
            else if (sweet1.Price < sweet2.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
