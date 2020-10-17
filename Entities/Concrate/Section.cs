using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class Section:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }

    }
}
