namespace PerformansysAnalys.Reports.TopQuestionsWithIncorrectAnswers
{
    public class TopQuestionsWithIncorrectAnswersItem
    {
      
        public int QuestionId { get; set; } // id вопроса
        public string Text { get; set; } = string.Empty; // текст вопроса
        public int DIF { get; set; } // процент правильных ответов на этот вопрос

    }
}
