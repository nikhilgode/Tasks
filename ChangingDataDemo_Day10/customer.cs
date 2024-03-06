namespace ChangingDataDemo_Day10
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("customer")]
    public partial class customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int customer_id { get; set; }

        [Required]
        [StringLength(255)]
        public string customer_name { get; set; }

        public int? city_id { get; set; }

        public virtual city city { get; set; }
    }
}
