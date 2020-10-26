using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class CourseCurriculum:IEntity
    {
        public int Id { get; set; }
        public virtual Curriculum Curriculum { get; set; }
        public int CurriculumId { get; set; }
        public virtual Course Course { get; set; }
        public int CourseId { get; set; }

    }
}
