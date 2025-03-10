﻿using System.ComponentModel.DataAnnotations;

namespace NZWalks.API.Models.DTO
{
    public class AddRegionRequestDto
    {
        [Required] // This makes the attribute required. First part of validation.
        [MinLength(3,ErrorMessage = "Code has to be a minimum of 3 characters")] // Second part of validation - making min and max length
        [MaxLength(3, ErrorMessage = "Code has to be a maximum of 3 characters")]
        public string Code { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Code has to be a maximum of 100 characters")]
        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}
