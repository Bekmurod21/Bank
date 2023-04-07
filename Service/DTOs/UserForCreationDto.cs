﻿using Domain.Entities;

namespace Service.DTOs
{
    public class UserForCreationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthOfDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
