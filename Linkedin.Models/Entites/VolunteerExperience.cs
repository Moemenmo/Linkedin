﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedin.Models.Entites
{
    [Table("VolunteerExperience")]
    public class VolunteerExperience
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }

        [ForeignKey("Company")]
        public Guid CompanyId { get; set; }
        public virtual SavedPlace Company { get; set; }
        public string Cause { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsPresent { get; set; }
    }
}
