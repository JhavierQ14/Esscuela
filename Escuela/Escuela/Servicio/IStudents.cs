﻿using Escuela.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Servicio
{
   public interface IStudents
    {
        List<Students> ListOfStudents();

        void insert(Students students);

        void Update(Students students);

        //void Delete(Students students);

    }
}
