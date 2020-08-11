using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BurnOut.Data.Models
{
    [Table("Workouts", Schema = "burnOut")]
    class Workout
    {
        [Key]
        public int Id { get; set; }
        public string WorkoutName { get; set; }
        public decimal Duration { get; set; }
        public string Difficulty { get; set; }
    }
}
