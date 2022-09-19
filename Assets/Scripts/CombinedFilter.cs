public class CombinedFilter
{
    public static int[] combinedFilter(int[] xs)
    {
        return FactFilter.facts(DifFilter.Diff(xs));
    }
}
