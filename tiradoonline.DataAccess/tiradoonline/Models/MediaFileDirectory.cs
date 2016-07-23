using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace tiradoonline.DataAccess.tiradoonline.Models
{
    public class modelMediaFileDirectory
    {
        
        public int MediaFileSettingID { get; set; }
        public int UserID { get; set; }
        public string MediaFileDirectoryName { get; set; }
        public DateTime create_dt { get; set; }

        //public virtual Users Users { get; set; }
    }
}
