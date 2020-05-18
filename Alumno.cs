using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFormsAlumno
{
    class Alumno
    {
        // Propiedades autoimplementadas

        public int Legajo { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int TipoDoc { get; set; }

        public int NumDoc { get; set; }

        public int Genero { get; set; }

        public int Turno { get; set; }

        public int Carrera { get; set; }

        public int Modalidad { get; set; }

        public double Nota1 { get; set; }

        public double Nota2 { get; set; }

        public double Nota3 { get; set; }

        // Constructores

        public Alumno()
        {
            Nombre = Apellido = "N/D";
            Legajo = TipoDoc = NumDoc = Genero = Turno = Carrera = Modalidad = 0;
            Nota1 = Nota2 = Nota3 = 0;
        }

        // Metodos






    }
}
