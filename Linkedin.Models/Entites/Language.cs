﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedin.Models.Entites
{
    public class Language
    {
        public Language()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Level Level { get; set; }
        public Guid UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
