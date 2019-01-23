﻿using System.ComponentModel.DataAnnotations;


namespace CoreWebAPI.Models
{
    public class BookForUpdateDto : BookForManipulationDto
    {
        [Required(ErrorMessage = "You should fill out a description.")]
        public override string Description
        {
            get
            {
                return base.Description;
            }

            set
            {
                base.Description = value;
            }
        }
    }
}
