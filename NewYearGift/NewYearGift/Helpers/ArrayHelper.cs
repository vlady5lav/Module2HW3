namespace NewYearGift
{
    public static class ArrayHelper
    {
        public static void ReverseSweetsArray(Sweet[] sweets)
        {
            var start = 0;
            var end = sweets.Length - 1;

            Sweet temp;

            while (start < end)
            {
                temp = sweets[start];
                sweets[start] = sweets[end];
                sweets[end] = temp;
                start++;
                end--;
            }
        }

        public static object[] CleanCapacity(Sweet[] sweets)
        {
            var count = 0;

            foreach (var item in sweets)
            {
                if (item != null)
                {
                    count++;
                }
            }

            var result = new Sweet[count];

            foreach (var item in sweets)
            {
                if (item != null)
                {
                    result[--count] = item;
                }
            }

            ReverseSweetsArray(result);

            return result;
        }
    }
}
