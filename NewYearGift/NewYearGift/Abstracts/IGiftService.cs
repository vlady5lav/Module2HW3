namespace NewYearGift
{
    public interface IGiftService
    {
        Sweet[] FilteredSweetGift { get; }
        double GiftTotalWeight { get; }
        Sweet[] SortedSweetGift { get; }
        Sweet[] SweetGift { get; }

        Sweet[] GetFilteredSweetGift(double calories);
        Sweet[] GetFilteredSweetGift(string name);
        Sweet[] GetFilteredSweetGift(SweetTypes sweetType);
        Sweet[] GetSortedSweetGift(string sort);
    }
}