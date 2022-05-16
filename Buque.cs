using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVA1
{
    internal class Buque
    {
        private string codigo;
        private string nombre;
        private string pais;
        private int cantidadContainers;
        private int cantidadContainersCargados;
        private int gastoTransporte;
        private List Container;

        public string Codigo { get => codigo;}
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }
        public int CantidadContainers { get => cantidadContainers; set => cantidadContainers = value; }
        public int CantidadContainersCargados { get => cantidadContainersCargados; set => cantidadContainersCargados = value; }
        public int GastoTransporte { get => gastoTransporte; set => gastoTransporte = value;}
        public List Container { get => Container; set => Container = value; }

        public Buque(string codigoBuque)
        {
            this.codigo = codigoBuque;
        }

        public Buque(string codigo, string nombre, string pais, int cantidadContainers, int cantidadContainersCargados, int gastoTransporte, List Container) : this(codigo)
        {
            this.nombre = nombre;
            this.pais = pais;
            this.cantidadContainers = cantidadContainers;
            this.cantidadContainersCargados = cantidadContainersCargados;
            this.gastoTransporte = gastoTransporte;
            this.Container = Container;
        }

    }
}

