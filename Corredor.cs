using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carreraliebre_tortuga
{
    class Corredor
    {
        private int _Numero;
        protected int _Posicion;
        private static Random  gen = new Random();

        public Corredor(int Numero)
        {
            _Numero = Numero;
            _Posicion = 0;
        }
        public int Numero
        {
            get { return _Numero; }

        }
        public int Posicion
        {
            get { return _Posicion; }

        }
        public override string ToString()
        {
            return _Numero.ToString()+ " Esta en la Posicion " +  _Posicion.ToString()+ " ";
        }
        public int Correr()
        {
            return gen.Next(1, 21);
        }


    }
}
