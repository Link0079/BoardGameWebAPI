using Imi.Project.Api.Core.Dtos.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Imi.Project.Api.Core.Dtos
{
    public class ArtistRequestDto : BaseDto
    {
        [Required]
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        //public bool IsDeleted { get; set; }
    }
}
