using System;
using AulaPOO_PolimosrfismoSobrecarga.classes;

namespace AulaPOO_PolimosrfismoSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Funcionario fun = new Funcionario(); 
            fun.Mostrar();
            fun.Mostrar("Paulo");
            fun.Mostrar(2);

            Console.Beep(900, 5000);
        }
    }
}
