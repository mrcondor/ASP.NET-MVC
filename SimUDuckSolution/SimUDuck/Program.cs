using SimUDuck.Interfaces;
using SimUDuck.Patos;
using System;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Pato Selvagem");
            //IPato patoSelvagem = new PatoSelvagem();
            //patoSelvagem.Grasnar();
            //patoSelvagem.Nadar("patoTeste");
            //patoSelvagem.Voar();

            //Console.WriteLine("Pato Cabeça Vermelha");
            //IPato patoCabecaVermelha = new PatoCabecaVermelha();
            //patoCabecaVermelha.Grasnar();
            //patoCabecaVermelha.Nadar();
            //patoCabecaVermelha.Voar();

            Simulador simulador = new Simulador();
            simulador.Executar(new PatoSelvagem());
            simulador.Executar(new PatoCabecaVermelha());
            simulador.Executar(new PatoReal());

            Console.ReadLine();
        }
    }
}
