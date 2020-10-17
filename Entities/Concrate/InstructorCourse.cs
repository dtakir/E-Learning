using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
   public class InstructorCourse:IEntity
    {
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
    }
}
