namespace tiradoonline.DataAccess.InterviewQuestionsAnswers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Answers
    {
        [Key]
        public int AnswerID { get; set; }

        public int QuestionID { get; set; }

        [Required]
        public string Answer { get; set; }

        public DateTime create_dt { get; set; }

        public virtual Questions Questions { get; set; }
    }
}
