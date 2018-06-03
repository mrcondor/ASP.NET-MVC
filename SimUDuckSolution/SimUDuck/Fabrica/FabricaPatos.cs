using SimUDuck.Interfaces;
using SimUDuck.Patos;
using System.Collections.Generic;

namespace SimUDuck.Fabrica
{
    public class FabricaPatos
    {
        public List<IPato> ObterPatos()
        {
            List<IPato> pato = new List<IPato>();
            pato.Add(new PatoSelvagem());
            pato.Add(new PatoCabecaVermelha());
            pato.Add(new PatoReal());

            return pato;
        }
    }
}
