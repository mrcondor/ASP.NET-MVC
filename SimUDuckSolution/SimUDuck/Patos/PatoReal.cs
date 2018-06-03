using SimUDuck.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Patos
{
    class PatoReal : IPato
    {
        public void Grasnar()
        {
            Console.WriteLine("PatoReal está grasnando");
        }

        public void Nadar()
        {
            Console.WriteLine("PatoReal está nadando");
        }

        public void Nadar(string nome)
        {
            Console.WriteLine(nome + " PatoReal está nandando");
        }

        public void Voar()
        {
            Console.WriteLine("PatoReal está voando");
        }
    }
}
