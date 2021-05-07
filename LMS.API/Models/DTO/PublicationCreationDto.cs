using System;
using LMS.API.Models.Entities;

namespace LMS.API.Models.DTO
{
    public class PublicationCreationDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublicationDate { get; set; }
        
        public DifficultyLevel Level { get; set; }
        
        public int TypeId { get; set; }
        public int SubjectId { get; set; }
    }
}