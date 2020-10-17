using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
   public class Curriculum:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Duration { get; set; }
        public int SectionId { get; set; }
    }
}
