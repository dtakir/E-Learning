using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class Course:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<CourseCategory> CourseCategories { get; set; }
        public virtual ICollection<CourseCurriculum> CourseCurriculums { get; set; }

    }
}
