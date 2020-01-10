using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace LandR.Models
{
    public class User{
        [Key]
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        public string Subject {get;set;}
        public string Rate {get;set;}
        public string Schedule {get;set;}
        public string ProfilePic {get;set;}

        [DataType(DataType.Password)]
        [Required]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]        
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirmation { get; set; }
        [InverseProperty("Tutor")]
        public List<Review> TutorReviews { get; set; }
        [InverseProperty("Poster")]
        public List<Review> StudentReviews { get; set; }
    }
}