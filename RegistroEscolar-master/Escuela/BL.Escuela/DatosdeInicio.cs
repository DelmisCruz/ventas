using System.Data.Entity;

namespace BL.Escuela
{
    internal class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto context)
        {
            var usuarioMaster = new Usuario();
            usuarioMaster.Nombre = "master";
            usuarioMaster.Contrasena = "123";

            context.Usuarios.Add(usuarioMaster);

            var grado1 = new Grado();
            grado1.Descripcion = "Kinder";
            grado1.Mensualidad = 2000;
            context.Grados.Add(grado1);

            var grado2 = new Grado();
            grado2.Descripcion = "First Grade";
            grado2.Mensualidad = 2300;
            context.Grados.Add(grado2);

            var grado3 = new Grado();
            grado3.Descripcion = "Second Grade";
            grado3.Mensualidad = 2600;
            context.Grados.Add(grado3);

            var grado4 = new Grado();
            grado4.Descripcion = "Third Grade";
            grado4.Mensualidad = 2900;
            context.Grados.Add(grado4);

            var grado5 = new Grado();
            grado5.Descripcion = "Fourth Grade";
            grado5.Mensualidad = 3200;
            context.Grados.Add(grado5);

            var grado6 = new Grado();
            grado6.Descripcion = "Fifth Grade";
            grado6.Mensualidad = 3500;
            context.Grados.Add(grado6);

            var grado7 = new Grado();
            grado7.Descripcion = "Sixth Grade";
            grado7.Mensualidad = 3800;
            context.Grados.Add(grado7);

            var clase1 = new Clase();
            clase1.Descripcion = "Español";
            clase1.Pago = 1050;
            context.Clases.Add(clase1);

            var clase2 = new Clase();
            clase2.Descripcion = "Math";
            clase2.Pago = 1050;
            context.Clases.Add(clase2);

            var clase3 = new Clase();
            clase3.Descripcion = "Science";
            clase3.Pago = 1100;
            context.Clases.Add(clase3);

            var clase4 = new Clase();
            clase4.Descripcion = "Reading";
            clase4.Pago = 1150;
            context.Clases.Add(clase4);

            var clase5 = new Clase();
            clase5.Descripcion = "Social Studies";
            clase5.Pago = 1150;
            context.Clases.Add(clase5);

            var clase6 = new Clase();
            clase6.Descripcion = "Spelling";
            clase6.Pago = 1150;
            context.Clases.Add(clase6);

            var clase7 = new Clase();
            clase7.Descripcion = "Grammar";
            clase7.Pago = 1150;
            context.Clases.Add(clase7);

            var clase8 = new Clase();
            clase8.Descripcion = "Computer";
            clase8.Pago = 1200;
            context.Clases.Add(clase8);

            var clase9 = new Clase();
            clase9.Descripcion = "Artes";
            clase9.Pago = 1000;
            context.Clases.Add(clase9);

            var clase10 = new Clase();
            clase10.Descripcion = "Musica";
            clase10.Pago = 1000;
            context.Clases.Add(clase10);

            var clase11 = new Clase();
            clase11.Descripcion = "Educacion Fisica";
            clase11.Pago = 1000;
            context.Clases.Add(clase11);          


            base.Seed(context); 
        }
    }
}