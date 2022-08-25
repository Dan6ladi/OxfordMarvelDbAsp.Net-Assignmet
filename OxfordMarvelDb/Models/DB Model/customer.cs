namespace OxfordMarvelDb.Models.DB_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerID { get; set; }

        [StringLength(255)]
        public string CustomerName { get; set; }

        [StringLength(255)]
        public string ContactName { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(255)]
        public string City { get; set; }

        [StringLength(255)]
        public string PostalCode { get; set; }

        [StringLength(255)]
        public string Country { get; set; }
    }
}
