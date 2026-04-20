namespace PerformanceAnalysis.Reports.StudentMonthlyProgress
{
    /// <summary>
    ///  Накопленные баллы конкретного студента.
    /// </summary>
    public class StudentMonthlyProgressItem
    {
        public DateTime Month { get; set; }
        public string MonthLabel { get; set; } = string.Empty;
        public int Score { get; set; }
        public int CumulativeScore { get; set; }
    }
}
