namespace OxfordMarvelDb.Models.DB_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class student
    {
        [Key]
        [StringLength(15)]
        public string student_id { get; set; }

        [StringLength(100)]
        public string student_name { get; set; }

        [StringLength(15)]
        public string student_email { get; set; }

        public int? student_phone { get; set; }
    }
}
