using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tiradoonline.InterviewQuestionsAnswers.Models
{
    public class modelInterviewQuestionsAnswers
    {
        public List<modelSubjects> Subjects { get; set; }
        public List<modelQuestions> Questions { get; set; }
        public List<modelAnswers> Answers { get; set; }
    }
}