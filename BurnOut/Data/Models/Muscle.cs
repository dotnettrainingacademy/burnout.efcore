using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BurnOut.Data.Models
{
    [Table("Muscles", Schema = "burnOut")]
    class Muscle
    {
        // Primary Key
        [Key] // => Data Annotation
        public int Id { get; set; }
        [Required]
        public string MuscleName { get; set; }
        public string Description { get; set; }
    }
}
