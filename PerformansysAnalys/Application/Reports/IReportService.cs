using PerformanceAnalysis.Reports.DayOfWeekActivity;
using PerformanceAnalysis.Reports.GroupLeadersAndLaggards;
using PerformanceAnalysis.Reports.GroupTread;
using PerformanceAnalysis.Reports.GroupTrend;
using PerformanceAnalysis.Reports.StudentMonthlyProgress;
using PerformanceAnalysis.Reports.StudentPassRate;
using PerformanceAnalysis.Reports.StudentPassRateSummary;
using PerformanceAnalysis.Reports.StudentRating;
using PerformanceAnalysis.Reports.StudentTestResults;
using PerformansysAnalys.Reports.DayOfWeekActivity;
using PerformansysAnalys.Reports.TopQuestionsWithIncorrectAnswers;

namespace PerformansysAnalys.Application.Reports
{
    public interface IReportService
    {
        Task<IEnumerable<GroupLeadersAndLaggardsItem>> GetGroupLeadersAndLaggardsAsync(GroupLeadersAndLaggardsFilter filter);
        Task<IEnumerable<StudentTestResultsItem>> GetStudentTestResultsAsync(StudentTestResultsFilter filter);
        Task<IEnumerable<GroupTrendItem>> GetGroupTrendAsync(GroupTrendFilter filter);
        Task<IEnumerable<StudentRatingItem>> GetStudentRatingAsync(StudentRatingFilter filter);
        Task<IEnumerable<StudentMonthlyProgressItem>> GetStudentMonthlyProgressAsync(StudentMonthlyProgressFilter filter);
        Task<IEnumerable<StudentPassRateItem>> GetStudentPassRateAsync(StudentPassRateSummaryFilter filter);
        Task<StudentPassRateSummaryItem?> GetStudentPassRateSummaryAsync(StudentPassRateSummaryFilter filter);
        Task<IEnumerable<DayOfWeekActivityItem>> GetDayOfWeekActivityAsync(DayOfWeekActivityFilter filter);
        Task<IEnumerable<TopQuestionsWithIncorrectAnswersItem>> GetTopQuestionsWithIncorrectAnswersAsync(TopQuestionsWithIncorrectAnswersFilter filter); // вопросы с самым низким процентом правильных ответов


    }
}
