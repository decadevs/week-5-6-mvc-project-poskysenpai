﻿namespace week_5_Assignment.Models.Entities
{
    public class UserDetail
    {
        public Guid Id { get; set; }
        public string Name { get; set; }    
        public string Email { get; set; }
        public string Phone { get; set; }

        public string Address { get; set; }

    }
}