namespace tiradoonline.DataAccess.InterviewQuestionsAnswers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Subjects
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subjects()
        {
            Questions = new HashSet<Questions>();
        }

        [Key]
        public int SubjectID { get; set; }

        [Required]
        [StringLength(100)]
        public string Subject { get; set; }

        public DateTime create_dt { get; set; }

        
        public virtual ICollection<Questions> Questions { get; set; }
    }
}
