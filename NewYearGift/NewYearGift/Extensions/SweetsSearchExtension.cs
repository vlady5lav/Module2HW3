namespace NewYearGift
{
    public static class SweetsSearchExtension
    {
        public static Sweet[] Search(this Sweet[] sweets, string name)
        {
            var indexes = new int[sweets.Length];
            var cycle = 0;
            var lastindex = 0;

            foreach (var sweet in sweets)
            {
                if (sweet.Name.Contains(name))
                {
                    indexes[lastindex] = cycle;
                    lastindex++;
                }

                cycle++;
            }

            return GetFiltered(sweets, indexes, lastindex);
        }

        public static Sweet[] Search(this Sweet[] sweets, double calories)
        {
            var indexes = new int[sweets.Length];
            var cycle = 0;
            var lastindex = 0;

            foreach (var sweet in sweets)
            {
                if (sweet.Calories <= calories + 10 && sweet.Calories >= calories - 10)
                {
                    indexes[lastindex] = cycle;
                    lastindex++;
                }

                cycle++;
            }

            return GetFiltered(sweets, indexes, lastindex);
        }

        public static Sweet[] Search(this Sweet[] sweets, SweetTypes sweetType)
        {
            var indexes = new int[sweets.Length];
            var cycle = 0;
            var lastindex = 0;

            foreach (var sweet in sweets)
            {
                if (sweet.SweetType == sweetType)
                {
                    indexes[lastindex] = cycle;
                    lastindex++;
                }

                cycle++;
            }

            return GetFiltered(sweets, indexes, lastindex);
        }

        public static Sweet[] GetFiltered(Sweet[] sweets, int[] indexes, int lastindex)
        {
            var filteredSweets = new Sweet[lastindex];

            for (int i = 0; i < lastindex; i++)
            {
                filteredSweets[i] = sweets[indexes[i]];
            }

            return filteredSweets;
        }
    }
}
