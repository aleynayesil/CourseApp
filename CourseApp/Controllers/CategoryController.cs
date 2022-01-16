using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Controllers
{
    public class CategoryController : Controller
    {
    
     [HttpGet("menu/{CatId}")]
     
        public IActionResult Course(string CatId)
        {
            var category = new MenuManager().GetCourseCategory();
            if (category.Id!=CatId)
            {
                return NotFound();
            }
            var model = new SectionViewModel
            {
                Id = category.Id,
                Title = category.Name,
                MenuCourses = category.Courses.Select(s => new CourseViewModel
                {
                    Image = s.Image,
                    Title = s.CourseCategory.Name,
                    Body = s.Description

                }).ToList()
            };
            return View(model);
        }
        [HttpPost("send-comment")]

        public JsonResult SendMenu([FromBody] CategoryInputModel model)
        {

            return Json(new { message = "kayıt başarılı" });
        }

    }
}
