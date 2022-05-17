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
        private Buque Buque;

        public string Codigo { get => codigo; }
        public string Marca { get => marca; set => marca = value; }
        public int CapacidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }
        public byte Tamaño { get => tamaño; set => tamaño = value; }
        public bool esRefrigerado { get => esRefrigerado; set => esRefrigerado = value; }
        public int pesoActual { get => pesoActual; set => pesoActual = value; }
        public

         public Container(string codigo, string marca, int capacidadMaxima, byte tamaño, bool esRefrigerado, int pesoActual, Buque buque)
        {
            if (pesoActual <= 0)
            {
                Console.WriteLine("El peso actual debe ser mayor a 0.");
            }
            else if (pesoActual > capacidadMaxima)
            {
                Console.WriteLine("El peso actual no puede superar la capacidad máxima de carga.");
            }
            else
            {
                this.Codigo = codigo;
                this.Marca = marca;
                this.CapacidadMaxima = capacidadMaxima;
                this.Tamaño = tamaño;
                this.EsRefrigerado = esRefrigerado;
                this.PesoActual = pesoActual;
                this.Buque = buque;
            }
        }

        public int CalcularGastosEnvio()
        {
            if (tamaño == 20)
                return 3500;
            if (tamaño == 40)
                return 9000;
            return 0;
        }

        public void SacarPeso(int peso)
        {
            if (peso <= 0)
                return;

            if (this.PesoActual - peso < 0)
                return;

            this.PesoActual = this.PesoActual - peso;
        }

        public int ValorPagoInspeccion()
        {
            return this.PesoActual * 5;
        }

        public bool PuedeSubir(int peso)
        {
            if (PesoActual + peso <= CapacidadMaxima)
            {
                Console.WriteLine($"El container puede subir la caja con mercadería que pesa {peso}");
                return true;
            }
            else
            {
                Console.WriteLine($"El container no puede subir la caja con mercadería que pesa {peso}");
                return false;
            }
        }

        public void toString()
        {
            Console.WriteLine($"Codigo: {Codigo} - Marca : {Marca} - Capacidad máxima: {CapacidadMaxima} - Tamaño: {Tamaño} - Es refrigerado: {EsRefrigerado} - Peso actual: {PesoActual}");
        }
    }
}



