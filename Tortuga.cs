using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carreraliebre_tortuga
{
    class Tortuga:Corredor
    {
        public Tortuga(int numero):base(numero)
        {

        }
        new public int Correr()
        {
            int paso = base.Correr();
            if (paso <= 8)
                _Posicion += 3;
            else if (paso <= 12)
                _Posicion += 6;
            else if (paso <= 16)
                _Posicion -= 5;
            else if (paso <= 20)
                _Posicion -= 9;
            return _Posicion;



        }
    }
}
