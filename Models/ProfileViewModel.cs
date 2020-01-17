using System;
using System.Collections.Generic;

namespace LandR.Models
{
    public class ProfileViewModel
    {
        public User User {get;set;}
        public List<Review> Reviews {get;set;}
    }
}