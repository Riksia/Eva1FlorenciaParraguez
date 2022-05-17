using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVA1
{
    internal class Buque
    {
        private string nombre;
        private string codigo;
        private string pais;
        private int cantidadContainers;
        private int cantidadContainersCargados;
        private int gastoTransporte;
        private List<Container> Containers;

        //public string Codigo { get ; set ; }
        //public string Nombre { get ; set ; }
        //public string Pais { get ; set ; }
        //public int CantidadContainers { get ; set ; }
        //public int CantidadContainersCargados { get ; set ; }
        //public int GastoTransporte { get ; set ; }
        //public List<Container> Containers { get ; set ; }

        public string Codigo { get => codigo;}
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }
        public int CantidadContainers { get => cantidadContainers; set => cantidadContainers = value; }
        public int CantidadContainersCargados { get => cantidadContainersCargados; set => cantidadContainersCargados = value; }
        public int GastoTransporte { get => gastoTransporte; set => gastoTransporte = value;}
        public List<Container> Containers { get => Container; set => Container = value; }

        public Buque(string codigo, string nombre, string pais, int cantidadContainers, int cantidadContainersCargados, int gastoTransporte)
        {
            if (codigo.Length < 5)
            {
                Console.WriteLine("El código del buque debe tener una longitud de al menos 5 caracteres");
            }
            else
            {
                this.Codigo = codigo;
                this.Nombre = nombre;
                this.Pais = pais;
                this.CantidadContainers = cantidadContainers;
                this.CantidadContainersCargados = cantidadContainersCargados;
                this.GastoTransporte = gastoTransporte;
                this.Containers = new List<Container>();
            }
        }

        public int CalcularGastosEnvio()
        {
            int costoEnvio = 0;
            foreach (var container in Containers)
            {
                if (container.tamaño == 20)
                {
                    costoEnvio += 3500;
                }
                else if (container.tamaño == 40)
                {
                    costoEnvio += 9000;
                }
            }

            this.GastoTransporte = costoEnvio;

            return costoEnvio;
        }

        public bool SubirContainer(Container nuevoContainer)
        {
            var espacioOcupado = 0;

            if (nuevoContainer.tamaño == 20)
                espacioOcupado = 1;
            if (nuevoContainer.tamaño == 40)
                espacioOcupado = 2;

            if (CantidadContainers == CantidadContainersCargados)
            {
                Console.WriteLine("No se puede subir el container debido a que el buque esta lleno.");
                return false;
            }

            if (CantidadContainersCargados + espacioOcupado >= CantidadContainers)
            {
                Console.WriteLine("No se puede subir el container debido a que supera la capacidad máxima del buque.");
                return false;
            }

            CantidadContainersCargados += espacioOcupado;

            Containers.Add(nuevoContainer);

            return true;
        }

        public void ListarContainers()
        {
            Console.WriteLine($"Información de containers en buque {this.Codigo}");
            foreach (var container in Containers)
            {
                container.toString();
            }
        }

        public void toString()
        {
            Console.WriteLine(codigo, nombre, pais, cantidadContainers, cantidadContainersCargados, gastoTransporte, ListarContainers);
            ListarContainers();
        }
    }

