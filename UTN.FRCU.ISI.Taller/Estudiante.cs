using System;

namespace UTN.FRCU.ISI.Taller
{
    public class Estudiante
    {

        public String NroLegajo { get; set; }

        public String Nombre { get; set; }

        public String Apellido { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1} ({2})", this.Apellido, this.Nombre, this.NroLegajo);
        }

    }
}
