namespace ApiTOKEN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class users
    {
        [Key]
        public int id_user { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [StringLength(50)]
        public string pass { get; set; }
    }
}
