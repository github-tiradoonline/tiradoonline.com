using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelPersonalInformation
    {
        public int PersonalInformationID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string AccountName { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Password2 { get; set; }

        [StringLength(50)]
        public string AccountNumber { get; set; }

        [StringLength(50)]
        public string AccountNumber2 { get; set; }

        [StringLength(50)]
        public string Rewards { get; set; }

        [StringLength(50)]
        public string Pin { get; set; }

        [StringLength(100)]
        public string Website { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Phone2 { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string ATM { get; set; }

        [StringLength(50)]
        public string Checking { get; set; }

        [StringLength(50)]
        public string RoutingNumber { get; set; }

        public int? CCTypeID { get; set; }

        [StringLength(10)]
        public string Expiration { get; set; }

        [StringLength(50)]
        public string CSV { get; set; }

        [StringLength(100)]
        public string SerialNumber { get; set; }

        [StringLength(1000)]
        public string Code { get; set; }

        
        public DateTime RegistrationDate { get; set; }

        public string Notes { get; set; }

        [StringLength(300)]
        public string Browser { get; set; }

        public bool Active { get; set; }

        public DateTime create_dt { get; set; }

        //public virtual PersonalInformationCards PersonalInformationCards { get; set; }

        //public virtual Users Users { get; set; }
    }
}
