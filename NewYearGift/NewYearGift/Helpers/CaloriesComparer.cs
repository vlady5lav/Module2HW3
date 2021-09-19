using System.Collections;

namespace NewYearGift
{
    public class CaloriesComparer : IComparer, ICaloriesComparer
    {
        public int Compare(object x, object y)
        {
            var sweet1 = x as Sweet;
            var sweet2 = y as Sweet;

            if (sweet1.Calories > sweet2.Calories)
            {
                return 1;
            }
            else if (sweet1.Calories < sweet2.Calories)
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
