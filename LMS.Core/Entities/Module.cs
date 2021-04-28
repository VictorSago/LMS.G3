﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Entities
{
    public class Module
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int CourseId { get; set; }

        // Navigation Properties
        public Course Course { get; set; }
        public ICollection<Activity> Activities { get; set; }
        public ICollection<Document> Documents { get; set; }
    }
}