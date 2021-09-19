using System.Collections;

namespace NewYearGift
{
    public class WeightComparer : IComparer, IWeightComparer
    {
        public int Compare(object x, object y)
        {
            var sweet1 = x as Sweet;
            var sweet2 = y as Sweet;

            if (sweet1.Weight > sweet2.Weight)
            {
                return 1;
            }
            else if (sweet1.Weight < sweet2.Weight)
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
