namespace apiDance.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clases
    {
        [Key]
        public int idClase { get; set; }

        [Required]
        [StringLength(50)]
        public string Dias { get; set; }

        public TimeSpan horas { get; set; }

        [Required]
        [StringLength(50)]
        public string Tema { get; set; }
    }
}
