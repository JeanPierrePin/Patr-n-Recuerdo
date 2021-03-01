using System;

namespace Patron_Recuerdo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos la clase que gestiona nuestro elementos.
            Caretaker caretaker = new Caretaker();
            //Creamos los backups.
            Horas c1 = new Horas();
            c1.asignarFecha(DateTime.Now);

            System.Threading.Thread.Sleep(5000);

            Horas c2 = new Horas();
            c2.asignarFecha(DateTime.Now);

            //guardamos elementos
            caretaker.agregarMemento(c1.guardaFecha());
            caretaker.agregarMemento(c2.guardaFecha());

            //obtenemos valores
            Memento memento1 = caretaker.dameMemento(0);
            Memento memento2 = caretaker.dameMemento(1);
            DateTime f1 = memento1.DameFecha();
            DateTime f2 = memento2.DameFecha();

            Console.WriteLine(f1.ToString());
            Console.WriteLine(f2.ToString());
            Console.ReadLine();


        }
    }
}
