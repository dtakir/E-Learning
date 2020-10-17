using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class CourseCategory:IEntity
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int CategoryId { get; set; }
    }
}
