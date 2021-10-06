using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Escuela
{
    public class EstudiantesBL
    {
        public BindingList<Estudiante> ListaEstudiantes { get; set; }

        public EstudiantesBL()
        {
            ListaEstudiantes = new BindingList<Estudiante>();

            var estudiante1 = new Estudiante();
            estudiante1.Id = "0501-2004-03733";
            estudiante1.Nombre = "Delmis";
            estudiante1.Apellido = "Rosa";
            estudiante1.Edad = 12;
            estudiante1.Celular = "9756-1972";
            estudiante1.Correo = "delmismarisela17@gmail.com";
            estudiante1.Grado = "Sexto";
            estudiante1.Clases = 10;
            estudiante1.Activo = true;

            ListaEstudiantes.Add(estudiante1);

            var estudiante2 = new Estudiante();
            estudiante2.Id = "0501-2012-03735";
            estudiante2.Nombre = "Alejandra";
            estudiante2.Apellido = "Bueso";
            estudiante2.Edad = 9;
            estudiante2.Celular = "33599260";
            estudiante2.Correo = "alemabu.bueso@gmail.com";
            estudiante2.Grado = "Cuarto";
            estudiante2.Clases = 8;
            estudiante2.Activo = true;

            ListaEstudiantes.Add(estudiante2);

            var estudiante3 = new Estudiante();
            estudiante3.Id = "0501-2004-03733";
            estudiante3.Nombre = "Ina";
            estudiante3.Apellido = "Cueva";
            estudiante3.Edad = 11;
            estudiante3.Celular = "88793976";
            estudiante3.Correo = "inacueva2@gmail.com";
            estudiante3.Grado = "Tercero";
            estudiante3.Clases = 7;
            estudiante3.Activo = true;

            ListaEstudiantes.Add(estudiante3);

        }

        public BindingList<Estudiante> ObtenerEstudiantes()
        {
            return ListaEstudiantes;
        }
    }

    public class Estudiante
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Grado { get; set; }
        public int Clases { get; set; }
        public bool Activo { get; set; }

    }
}
