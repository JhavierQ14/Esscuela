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
    public class StudentsController : Controller
    {
        private ApplicationDbContext app;
        private IStudents istudents;
        public StudentsController(IStudents istudents, ApplicationDbContext app)
        {
            this.istudents = istudents;
            this.app = app;
        }
        public IActionResult MostrarStudents()
        {
            var ListStudents = istudents.ListOfStudents();
            return View(ListStudents);
        }

       

        public IActionResult Registrar(string apellido, string nombre, string fecha, int id)
        {
            ViewBag.id = id;
            ViewBag.apellido = apellido;
            ViewBag.nombre = nombre;
            ViewBag.fecha = fecha;
      

            return View("Registrar");
        }

        [HttpPost]
        public IActionResult Save(string apellido, string nombre, DateTime fecha , int id) {

            Students student = new Students();


            if (id == 0)
            {
                student.LastName = apellido;
                student.FirstMiName = nombre;
                student.EnrollmentsDate = fecha;

                istudents.insert(student);
            }
            else
            {
                int update = id;
                Students editar = app.Students.Where(x => x.StudentId == update).FirstOrDefault();
                editar.LastName = apellido;
                editar.FirstMiName = nombre;
                editar.EnrollmentsDate = fecha;
                istudents.Update(editar);
            }


            return Redirect("/Students/MostrarStudents");
        }
    }
}
