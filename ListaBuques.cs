using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVA1
{
	internal class ListaBuques
    {
		Buque[] misBuques = new Buque[30];
		private bool hayEspacio;

		public ListaBuques()
        {
			hayEspacio = true;
        }

		public bool AgregarBuques(Buque nuevo)
        {
            bool res = false;
            int posicion = Disponible();
            if (posicion >-1)
            {
                misBuques[posicion] = nuevo;
                res=true;
            }
            return res;

        }

        private int Disponible()
        {
            int a = -1;
            for (int i = 0; i < misBuques.Length; i++)
            {
                if (misBuques[i] == null)
                {
                    a = i;
                    break;
                }
            }
            return a;
        }

        public bool Modificar(Buque m)
        {
            bool res = false;
            itn x = 0;
            foreach(Buque m2 in misBuques)
            {
                if (m2.Codigo == m.Codigo)
                {
                    misBuques[x].nombre
                }
            }
        }
    }
}

