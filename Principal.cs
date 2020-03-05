using ChainReponsability.CadenaResponsabilidad;
using ChainReponsability.DTO;
using System;

namespace ChainReponsability
{
    class Principal
    {
        static void Main(string[] args)
        {

            string conceptoCompra = "";
            decimal dImporteCompra = 0M;

            Console.WriteLine("Ingresa la solicitud de Compra:");
            conceptoCompra = Console.ReadLine();
            Console.WriteLine("Ingresa el importe de Compra:");
            dImporteCompra = Convert.ToDecimal(Console.ReadLine());

            AdministradorBOT administradorBOT = new AdministradorBOT();
            SolicitudDTO solicitud = new SolicitudDTO();
            solicitud = administradorBOT.ProcesaSolicitud(dImporteCompra);

            if (solicitud.lAutorizada)
                Console.WriteLine("{0} AUTORIZADA por el {1}", conceptoCompra, solicitud.cPuestoAutoriza);
            else
                Console.WriteLine("{0} DENEGADO", conceptoCompra);
        }
    }
}
