using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelUsers
    {
        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public bool UserTypeID { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string MobileEmail { get; set; }

        [StringLength(100)]
        public string Address1 { get; set; }

        [StringLength(100)]
        public string Address2 { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        public int? StateID { get; set; }

        [StringLength(20)]
        public string ZipCode { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public bool Administration { get; set; }

        public bool Contacts { get; set; }

        public bool PersonalInformation { get; set; }

        public bool Documents { get; set; }

        public bool Banking { get; set; }

        public bool CreditCards { get; set; }

        public bool MonthlyExpenses { get; set; }

        public bool? CollectionAgency { get; set; }

        public bool Photos { get; set; }

        public bool Music { get; set; }

        public bool MovieCollection { get; set; }

        public bool Movies { get; set; }

        public bool Snippets { get; set; }

        public bool Health { get; set; }

        public bool Jobs { get; set; }

        public bool Recovery { get; set; }

        public bool Timesheet { get; set; }

        public bool tiradoonline { get; set; }

        public bool Notes { get; set; }

        public bool ServerInformation { get; set; }

        [StringLength(50)]
        public string AIM { get; set; }

        [StringLength(50)]
        public string Yahoo { get; set; }

        [StringLength(50)]
        public string Hotmail { get; set; }

        [StringLength(50)]
        public string Skype { get; set; }

        [StringLength(50)]
        public string Gmail { get; set; }

        public bool Active { get; set; }

        public int? update_by { get; set; }

        public DateTime update_dt { get; set; }

        public DateTime create_dt { get; set; }
    }
}
