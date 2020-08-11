﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BurnOut.Data.Models
{
    [Table("Equipment", Schema = "burnOut")]
    class Equipment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string EquipmentName { get; set; }
        public int EquipmentWeight { get; set; }
    }
}
