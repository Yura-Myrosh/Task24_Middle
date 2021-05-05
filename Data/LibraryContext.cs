using Library.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Library.Data
{
    public class LibraryContext : DbContext
    {
    
        public LibraryContext() : base("name=LibraryConnection")
        {
        }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }

        public DbSet<Questionnaire> Questionnaires { get; set; }

    }
}
