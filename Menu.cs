using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVA1
{


    internal class Class1
    {
        

        var buque1 = new Buque("35899", "WAAA", "Chile", 10, 0, 0);
        var buque2 = new Buque("35877", "WEEE", "USA", 10, 0, 0);
        var buque3 = new Buque("35866", "WOOO", "China", 10, 0, 0);

        var container1 = new Container("CONTAINER1", "CTR", 1000, 20, false, 0);
        var container2 = new Container("CONTAINER2", "CTR", 1000, 40, false, 0);
        var container3 = new Container("CONTAINER3", "CTR", 1000, 40, false, 0);
        var container4 = new Container("CONTAINER4", "CTR", 1000, 20, false, 1000);

            buque1.SubirContainer(container1);
            buque1.SubirContainer(container2);
            buque2.SubirContainer(container3);
            buque2.SubirContainer(container4);

            buque1.ListarContainers();
            buque2.ListarContainers();

            container3.ValorPagoInspeccion();

            Console.WriteLine($"Costo a pagar por container: {container1.CalcularGastosEnvio()}");
            Console.WriteLine($"Costo a pagar por container: {container2.CalcularGastosEnvio()}");
            Console.WriteLine($"Costo a pagar por container: {container3.CalcularGastosEnvio()}");
            Console.WriteLine($"Costo a pagar por container: {container4.CalcularGastosEnvio()}");

            container4.PuedeSubir(2000);

            container1.SacarPeso(200);
    }
}
