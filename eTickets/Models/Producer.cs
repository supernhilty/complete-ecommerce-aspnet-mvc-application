﻿namespace eTickets.Models
{
    public class Producer
    {
        public int Id { get; set; }
        public string? ProfilePictureURL { get; set; }
        public string FullName { get; set; } = null!;
        public string? Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
