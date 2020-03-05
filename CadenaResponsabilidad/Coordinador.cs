using ChainReponsability.DTO;
using ChainReponsability.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainReponsability.CadenaResponsabilidad
{
    class Coordinador : IProcesadorSolicitud
    {
        private IProcesadorSolicitud _procesadorSolicitud = null;

        public void SetSiguienteSolicitud(IProcesadorSolicitud procesadorSolicitud)
        {
            this._procesadorSolicitud = procesadorSolicitud;
        }
        public IProcesadorSolicitud GetSiguienteSolicitud()
        {
            return this._procesadorSolicitud;
        }

        public SolicitudDTO ProcesaSolicitud(decimal dImporte)
        {

            if (dImporte <= 5000.00M)
            {
                return new SolicitudDTO("Coordinador", true);
            }
            else
            {
                return this._procesadorSolicitud.ProcesaSolicitud(dImporte);
            }
        }
    }
}
