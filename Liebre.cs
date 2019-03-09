using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carreraliebre_tortuga
{
    class Liebre:Corredor

    { 
        public Liebre(int numero):base(numero)
        {
           
        }

        new public int Correr()
        {
            //Del 1 al 4 no hara nada
            //del 5 al 9 avanzara 12
            //del 10 al 13 avanzara 5
            //del 14 al 16 retrocedera 4
            //del 17 al 20 retrocedera 8
            int paso = base.Correr();
            if (paso <= 4);

            else if (paso <= 9)
                _Posicion += 12;
            else if (paso <= 13)
                _Posicion += 5;
            else if (paso <= 16)
                _Posicion -= 4;
            else if (paso <= 20)
                _Posicion -= 8;

            return _Posicion;//Para regresarle la posicion en la que se quedo
        }

    }
}
