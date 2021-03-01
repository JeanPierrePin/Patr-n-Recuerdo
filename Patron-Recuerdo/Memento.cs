using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Recuerdo
{
    public class Memento
    {
        private DateTime fecha;

        public DateTime DameFecha()
        {
            return this.fecha;
        }

        public  Memento (DateTime tiempo)
        {
            this.fecha = tiempo; 
        }
    }
}