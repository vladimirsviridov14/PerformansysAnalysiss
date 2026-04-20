namespace PerformanceAnalysis.Reports.GroupLeadersAndLaggards
{
    /// <summary>
    /// Лидеры и отстающие в группе. Фильтр по направлениям и курсам

    /// </summary>
    public class GroupLeadersAndLaggardsFilter
    {
        public int? DirectionId { get; set; }
        public int? CourseId { get; set; }

    }
}
