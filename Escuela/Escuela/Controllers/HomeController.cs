using Escuela.Dominio;
using Escuela.Models;
using Escuela.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICourse icourse;
        private IRollements irollements;
        private IStudents istudents;

        public HomeController(ILogger<HomeController> logger, ICourse icourse, IRollements irollements, IStudents istudents)
        {
            this.icourse = icourse;
            this.irollements = irollements;
            this.istudents = istudents;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var listado = irollements.UnionDeTablas();
            //_ = listado;

            //Course course = new Course();
            //course.Title = "Poo";
            //course.Credits = 100;

            //icourse.Insertar(course);

            return View(listado);
        }
        public IActionResult GetAllForJoinJsonLing()
        {

            var listado = irollements.UnionDeTablas();

            var combinacionDeArreglos = (from union in listado
                                         select new
                                         {
                                             union.Course.Title,
                                             union.Student.LastName,
                                             union.Student.FirstMiName,
                                             union.grade


                                         }).ToList();
            return Json(new { combinacionDeArreglos });

        }
        /***************************************************************************************************************************************************/
        public IActionResult ComboBox()
        {

            var informationOftheCombo = icourse.ListarCursos();
            var informationOftheComboforStudents = istudents.ListOfStudents();

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
                        Text = iterarInfo.FirstMiName,
                        Value = Convert.ToString(iterarInfo.StudentId)
                    });


                ViewBag.estadoStudents = listStudents;

            }

            return View();
    
        }

        public IActionResult getinformationCombobox(Enrollment e)
        {
            _ = e;
            return View("ComboBox");
        }

/**************************************************************************************************************************************************/
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(string titulo, int creditos)
        {
            Course course = new Course();
            course.Title = titulo;
            course.Credits = creditos;

            icourse.Insertar(course);



            return View();
        }
/*****************************************************************************************************************************************************/
        public IActionResult GetAll()
        {
            var FormatoJson = icourse.ListarCursos();

            return Json(new { data = FormatoJson });
        }
/***************************************************************************************************************************************************/
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
