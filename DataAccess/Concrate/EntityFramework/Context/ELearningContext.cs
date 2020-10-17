using Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrate.EntityFramework.Context
{
    public class ELearningContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-0IICUG2\DT;Database=ELearning;Trusted_Connection=true;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Curriculum> Curricullums { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<CourseCurriculum> CourseCurriculums { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<InstructorCourse> InstructorCourses { get; set; }
        public DbSet<Section> Sections { get; set; }
    }
}
