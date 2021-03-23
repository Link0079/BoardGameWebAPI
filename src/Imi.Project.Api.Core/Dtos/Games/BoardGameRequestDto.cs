using Imi.Project.Api.Core.Dtos.Base;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Entities.Games;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Imi.Project.Api.Core.Dtos.Games
{
    public class BoardGameRequestDto : BaseDto
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Year { get; set; }
        public int Age { get; set; }
        public int Rating { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int PlayTime { get; set; }
        public bool Stock { get; set; }
        public string Description { get; set; }
        //public ICollection<CategoryResponseDto> Categories { get; set; }
        //public ICollection<ArtistResponseDto> Artists { get; set; }

    }
}
