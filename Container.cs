using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EVA1
{
    internal class Container
    {
        private string codigo;
        private string marca;
        private int capacidadMaxima;
        private byte tamaño;
        private bool esRefrigerado;
        private int pesoActual;
        
        public string Codigo { get => codigo; }
        public string Marca { get => marca; set => marca = value; }
        public int CapacidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }
        public byte Tamaño { get => tamaño; set => tamaño = value; }
        public bool esRefrigerado { get => esRefrigerado; set => esRefrigerado = value; }
        public int pesoActual { get => pesoActual; set => pesoActual = value; }

        public Container(string codigoContainer)
        {
            this.codigo = codigoContainer;
        }

        public Container(string codigo, string marca, int capacidadMaxima, byte tamaño, bool esRefrigerado, int pesoActual) : this(codigo)
        {
            this.marca = marca;
            this.capacidadMaxima = capacidadMaxima;
            this.tamaño = tamaño;
            this.esRefrigerado = esRefrigerado;
            this.pesoActual = pesoActual;
        }
    }
}



