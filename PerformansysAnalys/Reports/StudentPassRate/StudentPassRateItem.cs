namespace PerformanceAnalysis.Reports.StudentPassRate
{
    /// <summary>
    /// Процент пройденных тестов из всех доступных по каждому студенту.

    /// </summary>
    public class StudentPassRateItem
    {
        public int StudentId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string GroupName { get; set; } = string.Empty;
        public int TestAvailable { get; set; }
        public int TestPassed { get; set; }
        public decimal PassRate { get; set; }

    }
}
