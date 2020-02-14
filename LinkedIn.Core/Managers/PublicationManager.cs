﻿using Linkedin.DbContext;
using Linkedin.Models.Entites;
using LinkedIn.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn.Core.Managers
{
    public class PublicationManager : Repository<Publication, ApplicationDbContext>
    {
        private static PublicationManager Instance = null;
        public PublicationManager(ApplicationDbContext context) : base(context)
        {
        }
        public static PublicationManager GetInstance(ApplicationDbContext context)
        {
            if (Instance == null)
            {
                Instance = new PublicationManager(context);
            }
            return Instance;
        }
    }
}
