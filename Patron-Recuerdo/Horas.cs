using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Recuerdo
{
    public class Horas
    {
        private DateTime fecha;

        public void asignarFecha(DateTime f)
        {
            this.fecha = f;
        }

        public Memento guardaFecha()
        {
            return new Memento(this.fecha);
        }

        public void restauraFecha(Memento memento)
        {
            this.fecha = memento.DameFecha();
        }

        public DateTime dameFecha()
        {
            return fecha;
        }
    }
}