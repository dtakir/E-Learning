using Core.Entities;
using Core.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class UserCourses:IEntity
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public int UserId { get; set; }
        public virtual Course Course { get; set; }
        public int CourseId { get; set; }
    }
}
