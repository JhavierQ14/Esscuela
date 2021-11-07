using Escuela.Data;
using Escuela.Dominio;
using Escuela.Servicio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Controllers
{
    public class CuorseController : Controller
    {

        private ApplicationDbContext app;
        private ICourse icuorse;
        public CuorseController(ICourse icuorse, ApplicationDbContext app)
        {
            this.icuorse = icuorse;
            this.app = app;
        }
        public IActionResult MostrarCourses()
        {
            var ListCuorses = icuorse.ListarCursos();
            return View(ListCuorses);
        }



        public IActionResult Rcourses (string titulo, int creditos, int id)
        {
            ViewBag.id = id;
            ViewBag.titulo = titulo ;
            ViewBag.creditos = creditos;
           


            return View("Rcourses");
        }

        [HttpPost]
        public IActionResult SaveC(string titulo, int creditos, int id)
        {

            Course course = new Course();


            if (id == 0)
            {
                course.Title = titulo;
                course.Credits = creditos;
               
              

                icuorse.Insertar(course);
            }
            else
            {
                int update = id;
                Course editar = app.Courses.Where(x => x.CouserId  == update).FirstOrDefault();
                editar.Title = titulo;
                editar.Credits = creditos;
              
                icuorse.Update(editar);
            }


            return Redirect("/Cuorse/MostrarCourses");
        }

    }
}
