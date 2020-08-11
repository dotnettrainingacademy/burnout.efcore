using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BurnOut.Data.Models
{
    class Workout
    {
        [Key]
        public int Id { get; set; }
        public string WorkoutName { get; set; }
        public decimal Duration { get; set; }
        public string Difficulty { get; set; }
    }
}
