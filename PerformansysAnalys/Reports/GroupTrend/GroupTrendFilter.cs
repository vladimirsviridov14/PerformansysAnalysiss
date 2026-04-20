namespace PerformanceAnalysis.Reports.GroupTrend
{
    /// <summary>
    /// Динамика среднего балла по группам

    /// </summary>
    public class GroupTrendFilter
    {
        public List<int>? GroupIds { get; set; }

        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
