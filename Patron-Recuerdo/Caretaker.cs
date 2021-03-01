using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace Patron_Recuerdo
{
    public class Caretaker
    {
        private ArrayList fechas = new ArrayList();


        public void agregarMemento(Memento m)
        {
            fechas.Add(m);
        }

        public Memento dameMemento(int index)
        {
            return ((Memento)fechas[index]);
        }
    }
}