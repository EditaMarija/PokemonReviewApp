﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Dto
{
    public class ReviewerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public ICollection<Review> Reviews { get; set; }
        public ICollection<ReviewDto> Reviews { get; set; }
    }
}
