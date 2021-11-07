using Escuela.Data;
using Escuela.Dominio;
using Escuela.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Repositorio
{
    public class StudentsRepository : IStudents
    {
        private ApplicationDbContext bd;
        public StudentsRepository(ApplicationDbContext bd)
        {
            this.bd = bd;
        }

        public void insert(Students students)
        {
            bd.Add(students);
            bd.SaveChanges();
        }

        public List<Students> ListOfStudents()
        {
            return bd.Students.ToList();
        }

        public void Update(Students students)
        {
            bd.Update(students);
            bd.SaveChanges();
        }
    }
}
