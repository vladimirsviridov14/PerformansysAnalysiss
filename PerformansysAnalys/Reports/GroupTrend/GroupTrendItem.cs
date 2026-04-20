namespace PerformanceAnalysis.Reports.GroupTread
{
    public class GroupTrendItem
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; } = string.Empty;

        public DateTime Month { get; set; } 
        public string MonthLabel { get; set; }
        public decimal AverageScore { get; set; }
        public int AttemptsCount { get; set; }  
    }
}
