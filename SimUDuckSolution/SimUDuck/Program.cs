using SimUDuck.Fabrica;
using SimUDuck.Interfaces;
using SimUDuck.Patos;
using System;
using System.Collections.Generic;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaPatos fabrica = new FabricaPatos();
            Simulador simulador = new Simulador();

            var patos = fabrica.ObterPatos();

            foreach (var item in patos)
            {
                simulador.Executar(item);
            }

            Console.ReadLine();
        }
    }
}
