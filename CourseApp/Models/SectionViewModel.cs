using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public class Course
    {
        public string Id { get; set; }
        public string CorseUrl { get; set; }//?????
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string CatId { get; set; }
        public CourseCategory CourseCategory { get; set; }

    }
    public class CourseCategory
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
    
    public class MenuManager
    {
        public CourseCategory GetCourseCategory()
        {
           
            var category = new CourseCategory
            {
                Id = "1",
                Name = "Bilişim",
                Courses = new List<Course>()
            };
            category.Courses.Add(new Course
            {
                Id = Guid.NewGuid().ToString(),
                CorseUrl = "deneme-1",
                Title = "C# Dili Eğitimi",
                Description = "açıklama-1 Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ",
                Date = DateTime.Now.AddDays(-3),
                CourseCategory = category,
                CatId = category.Id,
                Image= "cod.jpg"

            });
            category.Courses.Add(new Course
            {
                Id = Guid.NewGuid().ToString(),
                CorseUrl = "deneme-2",
                Title = "Frontend Eğitimi",
                Description = "açıklama-2 It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Date = DateTime.Now.AddDays(-1),
                CourseCategory = category,
                CatId = category.Id,
                Image = "js.jpg"

            });
            category.Courses.Add(new Course
            {
                Id = Guid.NewGuid().ToString(),
                CorseUrl = "deneme-3",
                Title = "Backend Eğitimi",
                Description = "açıklama-3 Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.",
                Date = DateTime.Now.AddDays(-2),
                CourseCategory = category,
                CatId = category.Id,
                Image = "search.jpg"

            });
            category.Courses.Add(new Course
            {
                Id = Guid.NewGuid().ToString(),
                CorseUrl = "deneme-4",
                Title = "Phyton Eğitimi",
                Description = "açıklama-4 Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source",
                Date = DateTime.Now.AddDays(-3),
                CourseCategory = category,
                CatId = category.Id,
                Image = "girl.jpg"

            });
            category.Courses.Add(new Course
            {
                Id = Guid.NewGuid().ToString(),
                CorseUrl = "deneme-5",
                Title = "Javascript Eğitimi",
                Description = "açıklama-5  Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance.",
                Date = DateTime.Now.AddDays(-2),
                CourseCategory = category,
                CatId = category.Id,
                Image = "cod.jpg"

            });
            category.Courses.Add(new Course
            {
                Id = Guid.NewGuid().ToString(),
                CorseUrl = "deneme-6",
                Title = "C++ Dili Eğitimi",
                Description = "açıklama-6 The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham",
                Date = DateTime.Now.AddDays(-1),
                CourseCategory = category,
                CatId = category.Id,
                Image = "js.jpg"

            });
            return category;
        }
    }
    public class SectionViewModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public List<CourseViewModel> MenuCourses { get; set; }
    }

    public class CourseViewModel
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Body { get; set; }
    }
  
}
