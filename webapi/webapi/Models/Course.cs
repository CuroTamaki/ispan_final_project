﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace webapi.Models
{
    public partial class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int? TeacherId { get; set; }
        public int? Price { get; set; }
        public DateTime? Addedtime { get; set; }
        public string CourseVideo { get; set; }
        public string CourseImg { get; set; }
        public string Keyword { get; set; }
        public string CourseReqire { get; set; }
        public string CourseIntro { get; set; }
        public string Category { get; set; }
        public int? CourseLength { get; set; }
        public int? Chapter { get; set; }
    }
}