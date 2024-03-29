﻿using System.ComponentModel.DataAnnotations;

namespace IAmHere.Web.Models.Person
{
    public class PersonModel
    {
   
        public int Id { get; set; }

   
        public string FirstName { get; set; }
       
        public string LastName { get; set; }
   
        public int Age { get; set; }

        public string? Gender { get; set; }
        public DateTime? LastSeenDate { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
        public string? CaseDetails { get; set; }
        public string? ClothingDescription { get; set; }
        public int? HeightCM { get; set; }
        public int? WeightKG { get; set; }
        public string? HairColor { get; set; }
        public string? EyeColor { get; set; }
        public string? PhotoPath { get; set; }
        public string? Contact { get; set; }
        public string? CaseStatus { get; set; }
    }
}
