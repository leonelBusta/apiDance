namespace apiDance.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Instructores
    {
        [Key]
        public int idInstructores { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string apelidoMaterno { get; set; }

        [Required]
        [StringLength(50)]
        public string apellidoPaterno { get; set; }

        [Required]
        [StringLength(50)]
        public string edad { get; set; }

        [Required]
        [StringLength(50)]
        public string foto { get; set; }
    }
}
