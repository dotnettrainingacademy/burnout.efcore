using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BurnOut.Data.Models
{
    class Excercise
    {
        [Key]
        public int Id { get; set; }
        public int Steps { get; set; }
        public string Difficulty { get; set; }
        public decimal Time { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
    }
}
