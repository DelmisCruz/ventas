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
            estudiante1.Id = 1;
            estudiante1.Cedula = "0501-2004-03733";
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
            estudiante2.Id = 2;
            estudiante2.Cedula = "0501-2012-98900";
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
            estudiante3.Id = 3;
            estudiante3.Cedula = "0501-2011-23455";
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

        public Resultado GuardarEstudiante(Estudiante estudiante)
        {
            var resultado = Validar(estudiante);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            if (estudiante.Id == 0)
            {
                estudiante.Id = ListaEstudiantes.Max(item => item.Id) + 1;
            }
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarEstudiante()
        {
            var nuevoEstudiante = new Estudiante();
            ListaEstudiantes.Add(nuevoEstudiante);
        }

        public bool EliminarEstudiante(int id)
        {
            foreach (var estudiante in ListaEstudiantes)
            {
                if (estudiante.Id == id)
                {
                    ListaEstudiantes.Remove(estudiante);
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Estudiante estudiante)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(estudiante.Cedula) == true)
            {
                resultado.Mensaje = "Ingrese un numero de cedula";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(estudiante.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un Nombre";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(estudiante.Apellido) == true)
            {
                resultado.Mensaje = "Ingrese un Apellido";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(estudiante.Celular) == true)
            {
                resultado.Mensaje = "Ingrese un numero celular";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(estudiante.Correo) == true)
            {
                resultado.Mensaje = "Ingrese un correo valido";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(estudiante.Grado) == true)
            {
                resultado.Mensaje = "Ingrese un Grado de primero hasta sexto";
                resultado.Exitoso = false;
            }
            if (estudiante.Edad <= 0)
            {
                resultado.Mensaje = "La edad no debe ser menor que cero";
                resultado.Exitoso = false;
            }
            if (estudiante.Clases <= 0)
            {
                resultado.Mensaje = "Las clases deben ser mayor a 0";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }

    public class Estudiante
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Grado { get; set; }
        public int Clases { get; set; }
        public bool Activo { get; set; }

    }
    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
