using Escuela.Data;
using Escuela.Dominio;
using Escuela.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Controllers
{
    public class EnrollementsController : Controller
    {

        private ApplicationDbContext app;
        private IRollements irollements;
        private IStudents istudents;
        private ICourse icourse;
        public EnrollementsController(IRollements irollements , ApplicationDbContext app, IStudents istudents, ICourse icourse)
        {
           
            this.irollements = irollements;
            this.app = app;
            this.istudents = istudents;
            this.icourse = icourse;
        }
        public IActionResult Union()
        {

            var enrollementsList = irollements.UnionDeTablas();
            return View(enrollementsList);
        }


        public IActionResult Combobox()
        {

           
            var informationOftheComboforStudents = istudents.ListOfStudents();
            var informationOftheCombo = icourse.ListarCursos();

            List<SelectListItem> list = new List<SelectListItem>();
            List<SelectListItem> listStudents = new List<SelectListItem>();

            foreach (var iterarInfo in informationOftheCombo)
            {
                list.Add(
                    new SelectListItem
                    {
                        Text = iterarInfo.Title,
                        Value = Convert.ToString(iterarInfo.CouserId)
                    });


                ViewBag.estado = list;

            }
            foreach (var iterarInfo in informationOftheComboforStudents)
            {
                listStudents.Add(
                    new SelectListItem
                    {
                        Text = iterarInfo.FirstMiName + " " + iterarInfo.LastName,
                        Value = Convert.ToString(iterarInfo.StudentId)
                    });


                ViewBag.estadoStudents = listStudents;

            }

            return View();

        }

        public IActionResult getinformation()
        {

            return View("Combobox");
        }

        public IActionResult Save(Enrollment enrollments)
        {
            Enrollment enrollement = new Enrollment();
            enrollement.CourseId = enrollments.CourseId;
            enrollement.StudentId = enrollments.StudentId;
            enrollement.grade = enrollments.grade;

            irollements.Insert(enrollement);

            return Redirect("/Enrollements/Union");
        }
       

    }
}
