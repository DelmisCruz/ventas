using System.Data.Entity;

namespace BL.Escuela
{
    internal class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto context)
        {
            var grado1 = new Grado();
            grado1.Descripcion = "Primer Grado";
            context.Grados.Add(grado1);

            var grado2 = new Grado();
            grado2.Descripcion = "Segundo Grado";
            context.Grados.Add(grado2);

            var grado3 = new Grado();
            grado3.Descripcion = "Tercer Grado";
            context.Grados.Add(grado3);

            var grado4 = new Grado();
            grado4.Descripcion = "Cuarto Grado";
            context.Grados.Add(grado4);

            var grado5 = new Grado();
            grado5.Descripcion = "Quinto Grado";
            context.Grados.Add(grado5);

            var grado6 = new Grado();
            grado6.Descripcion = "Sexto Grado";
            context.Grados.Add(grado6);

            var clase1 = new Clase();
            clase1.Descripcion = "Español";
            context.Clases.Add(clase1);

            var clase2 = new Clase();
            clase2.Descripcion = "Matematica";
            context.Clases.Add(clase2);

            var clase3 = new Clase();
            clase3.Descripcion = "Ciencias";
            context.Clases.Add(clase3);

            var clase4 = new Clase();
            clase4.Descripcion = "Ingles";
            context.Clases.Add(clase4);

            var clase5 = new Clase();
            clase5.Descripcion = "Estudios Sociales";
            context.Clases.Add(clase5);

            var clase6 = new Clase();
            clase6.Descripcion = "Fisica";
            context.Clases.Add(clase6);

            base.Seed(context); 
        }
    }
}