using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LandR.Models {
    public class Review{
        [Key]
        public int ReviewId { get; set; }
        [Required]
        public int TutorId { get; set; }
        public User Tutor { get; set; }

        [Required]
        public int PosterId { get; set; }
        public  User Poster { get; set; }
        [Required]
        [Range(1,5)]
        public int Rating { get; set; }
        [Required]
        [MinLength(25, ErrorMessage = "Review must be at least 25 characters")]
        [MaxLength(500, ErrorMessage = "Review must be less than 500 characters")]
        public string ReviewText {get;set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


    }
}