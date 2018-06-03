using SimUDuck.Interfaces;
using System;

namespace SimUDuck.Patos
{
    class PatoCabecaVermelha : IPato
    {
        public void Grasnar()
        {
            Console.WriteLine("PatoCabecaVermelha está grasnando");
        }

        public void Nadar()
        {
            Console.WriteLine("PatoCabecaVermelha está nadando");
        }

        public void Nadar(string nome)
        {
            Console.WriteLine(nome + " PatoCabecaVermelha está nandando");
        }

        public void Voar()
        {
            Console.WriteLine("PatoCabecaVermelha está voando");
        }
    }
}
